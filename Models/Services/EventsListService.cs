using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public class EventsListService: IEventsListService
    {
        public static List<EventItem> _listOfEvents = new List<EventItem>();
        private float startFireAlarmTime;
        private readonly IPeopleService _peopleService;
        private IElevatorsManager _elevatorsManager;
        public EventsListService(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }
        public void AddFireAlarmEvent( float turnOnFireAlarmTime, float durationTimeFireAlarm)
        {
            _listOfEvents.Add(new EventItem(KindOfEvent.FireAlarm, turnOnFireAlarmTime, turnOnFireAlarmTime));
        }
        public void AddCreatePeopleEvent(int peopleCount, int currentFloor, int destinationFloor,
            float createPeopleTime)
        {
            _listOfEvents.Add(new EventItem( KindOfEvent.CreatePeople,  peopleCount,  currentFloor,  destinationFloor,
             createPeopleTime));
        }

        public void SortListOfEvents()
        {
            _listOfEvents = _listOfEvents.OrderBy(s => s.TimeMarkers[0]).ToList();
        }

        public void TurnOnEvent( float time, IElevatorsManager elevatorsManager )
        {
            if( _listOfEvents.Count != 0 )
            {
                if (_elevatorsManager == null) _elevatorsManager = elevatorsManager;
                EventItem eventItem = _listOfEvents.First();
                if (eventItem.TimeMarkers[0] < time)
                {
                    if ( eventItem.KindOfEvent == KindOfEvent.CreatePeople )
                    {
                        _peopleService.CreatePeople(eventItem.Parameters[0], eventItem.Parameters[1], eventItem.Parameters[2]);
                        _listOfEvents.Remove(eventItem);
                    }
                    else
                    {
                        if( startFireAlarmTime == 0 )
                        {
                            _elevatorsManager.Fire();
                            startFireAlarmTime = time;
                        }
                        else if( time - startFireAlarmTime > eventItem.TimeMarkers[1] && _elevatorsManager.Fire() )
                        {
                            _listOfEvents.Remove(eventItem);
                            startFireAlarmTime = 0;
                        }
                    }
                }

            }

        }
    }
}
