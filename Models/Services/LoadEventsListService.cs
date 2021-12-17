using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public class LoadEventsListService : ILoadService<EventItem>
    {
        public void Import(string importAddress)
        {
            EventsListService._listOfEvents.Add(new EventItem(KindOfEvent.FireAlarm, 15f, 15f));
            EventsListService._listOfEvents.Add(new EventItem(KindOfEvent.CreatePeople, 13, 3,
                10,
                7f));
            //EventsListService._listOfEvents.Add(new EventItem(KindOfEvent.FireAlarm, turnOnFireAlarmTime, turnOnFireAlarmTime));
        }

        public void Export(string exportAddress)
        {
            // EventsListService._listOfEvents.Add(new EventItem(KindOfEvent.CreatePeople, peopleCount, currentFloor, destinationFloor,
            //    createPeopleTime));
        }
    }
}