using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public interface IElevatorsManager
    {
        float GetTime();
        void InitializeElevatorRepository();
        void StartSimulation();
        event Action DataUpdated;
        bool[,] GetElevatorsGrid();
        void ElevatorsMovingCycle();
        void Decide(Elevator elevator);
        void MoveElevator(Elevator elevator);
        void StopSimulation();
        void PlayPauseSimulation();
        void SpeedUp();
        void SlowDown();
        bool Fire();
    }
}
