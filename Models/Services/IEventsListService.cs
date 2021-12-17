using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IEventsListService
    {
        void AddFireAlarmEvent(float turnOnFireAlarmTime, float durationTimeFireAlarm);
        void AddCreatePeopleEvent(int peopleCount, int currentFloor, int destinationFloor,
            float createPeopleTime);
        void SortListOfEvents();
        void TurnOnEvent(float time, IElevatorsManager elevatorsManager);
    }
}
