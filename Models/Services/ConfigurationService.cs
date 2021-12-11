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
        private ConfigurationData _configurationData = new ConfigurationData();
        private int _currentElevator = 0;

        public bool IsConfigurationSet()
        {
            return ConfigurationData._capacity != null &&
                   ConfigurationData._maxAcceleration != null &&
                   ConfigurationData._maxSpeed != null &&
                   ConfigurationData._capacity[ConfigurationData._countElevators - 1] != 0 &&
                   ConfigurationData._maxAcceleration[ConfigurationData._countElevators - 1] != 0 &&
                   ConfigurationData._maxSpeed[ConfigurationData._countElevators - 1] != 0 &&
                   ConfigurationData._countElevators != 0 &&
                   ConfigurationData._countFloors != 0;
        }

        public bool SetConfiguration(int countFloors, int countElevators)
        {
            if (ConfigurationData.MAX_COUNT_FLOORS >= countFloors &&
                ConfigurationData.MAX_COUNT_ELEVATORS >= countElevators)
            {
                ConfigurationData._countFloors = countFloors;
                ConfigurationData._countElevators = countElevators;
                ConfigurationData._capacity = new int[countElevators];
                ConfigurationData._maxAcceleration = new float[countElevators];
                ConfigurationData._maxSpeed = new float[countElevators];
                return true;
            }
            return false;
        }

        public bool SetElevatorsConfiguration(float maxSpeed, float maxAcceleration, int capacity, bool isTemplate)
        {
            if (_currentElevator >= ConfigurationData._countElevators)
                return false;
            if (isTemplate)
            {
                for (;
                    _currentElevator < ConfigurationData.MAX_COUNT_ELEVATORS &&
                    _currentElevator < ConfigurationData._countElevators;
                    _currentElevator++)
                {
                    ConfigurationData._capacity[_currentElevator] = capacity;
                    ConfigurationData._maxAcceleration[_currentElevator] = maxAcceleration;
                    ConfigurationData._maxSpeed[_currentElevator] = maxSpeed;
                }
            }
            else
            {
                ConfigurationData._capacity[_currentElevator] = capacity;
                ConfigurationData._maxAcceleration[_currentElevator] = maxAcceleration;
                ConfigurationData._maxSpeed[_currentElevator] = maxSpeed;
                _currentElevator++;
            }
            return true;
        }
    }
}
