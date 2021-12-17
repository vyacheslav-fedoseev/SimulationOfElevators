using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IConfigurationService
    {
        void SetStrategy(string strategy);
        bool IsConfigurationSet();
        bool SetConfiguration(int countFloors, int countElevators);
        bool SetElevatorsConfiguration(float maxSpeed, float maxAcceleration, int capacity, bool isTemplate);
    }
}
