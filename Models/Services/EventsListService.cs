using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public class EventsListService : IEventsListService
    {
        public static List<EventItem> ListOfEvents = new List<EventItem>();
        private float _startFireAlarmTime;
        private readonly IPeopleService _peopleService;
        private IElevatorsManager _elevatorsManager;
        public EventsListService(IPeopleService peopleService) => _peopleService = peopleService;

        public void AddFireAlarmEvent(float turnOnFireAlarmTime, float durationTimeFireAlarm) =>
            ListOfEvents.Add(new EventItem(KindOfEvent.FireAlarm, turnOnFireAlarmTime, turnOnFireAlarmTime));

        public void AddCreatePeopleEvent(int peopleCount, int currentFloor, int destinationFloor,
            float createPeopleTime) =>
            ListOfEvents.Add(new EventItem(KindOfEvent.CreatePeople, peopleCount, currentFloor, destinationFloor,
                createPeopleTime));

        public void SortListOfEvents() =>
            ListOfEvents = ListOfEvents.OrderBy(s => s.TimeMarkers[0]).ToList();

        public void TurnOnEvent(float time, IElevatorsManager elevatorsManager)
        {
            if (ListOfEvents.Count == 0) return;
            if (_elevatorsManager == null) _elevatorsManager = elevatorsManager;
            var eventItem = ListOfEvents.First();
            if (!(eventItem.TimeMarkers[0] < time)) return;
            if (eventItem.KindOfEvent == KindOfEvent.CreatePeople)
            {
                _peopleService.CreatePeople(eventItem.Parameters[0], eventItem.Parameters[1], eventItem.Parameters[2]);
                ListOfEvents.Remove(eventItem);
            }
            else
            {
                if (_startFireAlarmTime == 0)
                {
                    _elevatorsManager.Fire();
                    _startFireAlarmTime = time;
                }
                else if (time - _startFireAlarmTime > eventItem.TimeMarkers[1] && _elevatorsManager.Fire())
                {
                    ListOfEvents.Remove(eventItem);
                    _startFireAlarmTime = 0;
                }
            }

        }
    }
}
