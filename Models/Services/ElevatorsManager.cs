using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repositories;
using Models.Entities;

namespace Models.Services
{
    public class ElevatorsManager : IElevatorsManager
    {
        private IElevatorRepository _elevatorsRepository;

        public ElevatorsManager(IElevatorRepository elevatorsRepository)
        {
            _elevatorsRepository = elevatorsRepository;
        }

        public void InitializeElevatorRepository()
        {
            for(int i=0; i< ConfigurationData._countElevators; i++)
            {
                _elevatorsRepository.Add(ConfigurationData._maxAcceleration[i], ConfigurationData._maxSpeed[i], ConfigurationData._capacity[i]);
            }
        }

    }
}
