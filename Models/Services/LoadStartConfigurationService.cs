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

            ConfigurationData.CountFloors = int.Parse(new string(queueLines.Dequeue().Where(char.IsDigit).ToArray()));
            ConfigurationData.CountElevators = int.Parse(new string(queueLines.Dequeue().Where(char.IsDigit).ToArray()));
            _service.SetConfiguration(ConfigurationData.CountFloors, ConfigurationData.CountElevators);
            queueLines.Dequeue();
            queueLines.Dequeue();

            var queueLiftInfo = new Queue<float>();
            for (var i = 0; i < ConfigurationData.CountElevators; i++)
            {
                var words = queueLines.Dequeue().Split('\t');
                foreach (var word in words)
                    if (word != string.Empty)
                        queueLiftInfo.Enqueue(float.Parse(word));

                queueLiftInfo.Dequeue();
                ConfigurationData.MaxSpeed[i] = queueLiftInfo.Dequeue();
                ConfigurationData.MaxAcceleration[i] = queueLiftInfo.Dequeue();
                ConfigurationData.Capacity[i] = (int)queueLiftInfo.Dequeue();
            }
        }

        public void Export(string exportAddress)
        {
            string strInfo = null;
            for (var i = 1; i <= ConfigurationData.CountElevators; i++)
                strInfo += $"\t{i}\t\t{ConfigurationData.MaxSpeed[i - 1]}\t\t\t{ConfigurationData.MaxAcceleration[i - 1]}\t\t{ConfigurationData.Capacity[i - 1]}\n";
            string[] info =
            {
                $"Количество этажей: {ConfigurationData.CountFloors};",
                $"Количество лифтов: {ConfigurationData.CountElevators};\n",
                "Номер лифта; Максимальная скорость; Максимальное ускорение; Вместимость;",
                strInfo
            };
            File.WriteAllLines(exportAddress ?? "StartConfigurationInfo.txt", info);
        }
    }
}
