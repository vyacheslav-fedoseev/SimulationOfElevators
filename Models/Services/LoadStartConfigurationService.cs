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
        public void Import()
        {
        }

        public void Export(string exportAddress)
        {
            string str = null;
            for (var i = 1; i <= ConfigurationData._countElevators; i++)
                str += $"\t{i}\t\t{ConfigurationData._maxSpeed[i - 1]}\t\t\t{ConfigurationData._maxAcceleration[i - 1]}\t\t{ConfigurationData._capacity[i - 1]}\n";

            string[] lines =
            {
                $"Количество этажей: {ConfigurationData._countFloors};",
                $"Количество лифтов: {ConfigurationData._countElevators};\n",
                "Номер лифта; Максимальная скорость; Максимальное ускорение; Вместимость;",
                str
            };
            File.WriteAllLines(exportAddress ?? "StartConfigurationInfo.txt", lines);



        }
    }
}
