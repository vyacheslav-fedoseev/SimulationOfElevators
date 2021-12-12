using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Models.Entities;

namespace Models.Services
{
    public class LoadStartConfigurationService : ILoadService<ConfigurationData>
    {
        private readonly ConfigurationService _service = new ConfigurationService();
        public void Import(string importAddress)
        {
            var queueLines = new Queue<string>();
            foreach (var element in File.ReadAllLines(importAddress))
                queueLines.Enqueue(element);

            ConfigurationData._countFloors = int.Parse(new string(queueLines.Dequeue().Where(char.IsDigit).ToArray()));
            ConfigurationData._countElevators = int.Parse(new string(queueLines.Dequeue().Where(char.IsDigit).ToArray()));
            _service.SetConfiguration(ConfigurationData._countFloors, ConfigurationData._countElevators);
            queueLines.Dequeue();
            queueLines.Dequeue();

            var queueLiftInfo = new Queue<float>();
            for (var i = 0; i < ConfigurationData._countElevators; i++)
            {
                var words = queueLines.Dequeue().Split('\t');
                foreach (var word in words)
                    if (word != string.Empty)
                        queueLiftInfo.Enqueue(float.Parse(word));

                queueLiftInfo.Dequeue();
                ConfigurationData._maxSpeed[i] = queueLiftInfo.Dequeue();
                ConfigurationData._maxAcceleration[i] = queueLiftInfo.Dequeue();
                ConfigurationData._capacity[i] = (int)queueLiftInfo.Dequeue();
            }
        }

        public void Export(string exportAddress)
        {
            string strInfo = null;
            for (var i = 1; i <= ConfigurationData._countElevators; i++)
                strInfo += $"\t{i}\t\t{ConfigurationData._maxSpeed[i - 1]}\t\t\t{ConfigurationData._maxAcceleration[i - 1]}\t\t{ConfigurationData._capacity[i - 1]}\n";
            string[] info =
            {
                $"Количество этажей: {ConfigurationData._countFloors};",
                $"Количество лифтов: {ConfigurationData._countElevators};\n",
                "Номер лифта; Максимальная скорость; Максимальное ускорение; Вместимость;",
                strInfo
            };
            File.WriteAllLines(exportAddress ?? "StartConfigurationInfo.txt", info);
        }
    }
}
