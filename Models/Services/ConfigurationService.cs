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

        public bool SetConfiguration(int countFloors, int countElevators)
        {
            if (ConfigurationData.MAX_COUNT_FLOORS < countFloors && ConfigurationData.MAX_COUNT_ELEVATORS < countElevators)
            {
                _configurationData._countFloors = countFloors;
                _configurationData._countElevators = countElevators;
                _configurationData._capacity = new int[countElevators];
                _configurationData._maxAcceleration = new float[countElevators];
                _configurationData._maxSpeed = new float[countElevators];
                return true;
            }
            else
                return false;
        }
        public bool SetElevatorsConfiguration(float maxSpeed, float maxAcceleration, int capacity, bool isTemplate)
        {
            if (_currentElevator >= ConfigurationData.MAX_COUNT_ELEVATORS)
                return false;
            if (isTemplate)
            {
                for (; _currentElevator < ConfigurationData.MAX_COUNT_ELEVATORS; _currentElevator++)
                {
                    _configurationData._capacity[_currentElevator] = capacity;
                    _configurationData._maxAcceleration[_currentElevator] = maxAcceleration;
                    _configurationData._maxSpeed[_currentElevator] = maxSpeed;
                }
            }
            else
            {
                _configurationData._capacity[_currentElevator] = capacity;
                _configurationData._maxAcceleration[_currentElevator] = maxAcceleration;
                _configurationData._maxSpeed[_currentElevator] = maxSpeed;
                _currentElevator++;
            }
            return true;
        }
    }
}
