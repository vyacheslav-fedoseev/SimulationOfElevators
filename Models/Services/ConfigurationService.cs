using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private int _currentElevator;

        public bool IsConfigurationSet()
        {
            return ConfigurationData.Capacity != null &&
                   ConfigurationData.MaxAcceleration != null &&
                   ConfigurationData.MaxSpeed != null &&
                   ConfigurationData.CountElevators != 0 &&
                   ConfigurationData.CountFloors != 0 &&
                   ConfigurationData.Capacity[ConfigurationData.CountElevators - 1] != 0 &&
                   ConfigurationData.MaxAcceleration[ConfigurationData.CountElevators - 1] != 0 &&
                   ConfigurationData.MaxSpeed[ConfigurationData.CountElevators - 1] != 0 &&
                   ConfigurationData._strategy != Strategy.None;
        }

        public bool SetConfiguration(int countFloors, int countElevators)
        {
            if (ConfigurationData.MaxCountFloors >= countFloors &&
                ConfigurationData.MaxCountElevators >= countElevators)
            {
                ConfigurationData.CountFloors = countFloors;
                ConfigurationData.CountElevators = countElevators;
                ConfigurationData.Capacity = new int[countElevators];
                ConfigurationData.MaxAcceleration = new float[countElevators];
                ConfigurationData.MaxSpeed = new float[countElevators];
                return true;
            }
            return false;
        }

        public void SetStrategy(string strategy)
        {
            ConfigurationData._strategy = strategy.Equals("Минимальное время ожидания") 
                ? Strategy.MinWaitingTime 
                : Strategy.MinIdleRides;
        }

        public bool SetElevatorsConfiguration(float maxSpeed, float maxAcceleration, int capacity, bool isTemplate)
        {
            if (_currentElevator >= ConfigurationData.CountElevators)
                return false;
            if (isTemplate)
            {
                for (;
                    _currentElevator < ConfigurationData.MaxCountElevators &&
                    _currentElevator < ConfigurationData.CountElevators;
                    _currentElevator++)
                {
                    ConfigurationData.Capacity[_currentElevator] = capacity;
                    ConfigurationData.MaxAcceleration[_currentElevator] = maxAcceleration;
                    ConfigurationData.MaxSpeed[_currentElevator] = maxSpeed;
                }
            }
            else
            {
                ConfigurationData.Capacity[_currentElevator] = capacity;
                ConfigurationData.MaxAcceleration[_currentElevator] = maxAcceleration;
                ConfigurationData.MaxSpeed[_currentElevator] = maxSpeed;
                _currentElevator++;
            }
            return true;
        }
    }
}
