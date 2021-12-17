using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IStatisticsService
    {
        string GetStatistcs();
        void IncrementCountOfRides(int id, bool IsIdle);
        void IncrementCountOfFireAlarms();
        void IncrementCountOfPeople(int id);
        void IncrementFireAlarmsTime(float time);
        void IncrementPeopleWaitingTime(float time);
        void SetMaxPeopleWaitingTime(float time);
        void IncrementCountOfPeople();
    }
}
