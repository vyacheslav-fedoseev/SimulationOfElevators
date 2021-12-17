using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public enum KindOfEvent { CreatePeople = 0, FireAlarm = 1 }
    public class EventItem
    {
        public KindOfEvent KindOfEvent { get; private set; }
        public float[] TimeMarkers { get; private set; }
        public int[] Parameters { get; private set; }

        public EventItem( KindOfEvent kindOfEvent, int peopleCount, int currentFloor, int destinationFloor,
            float createPeopleTime)
        {
            KindOfEvent = kindOfEvent;
            TimeMarkers = new float[1];
            Parameters = new int[3];
            if (KindOfEvent == KindOfEvent.CreatePeople)
            {
                TimeMarkers[0] = createPeopleTime;
                Parameters[0] = peopleCount;
                Parameters[1] = currentFloor;
                Parameters[2] = destinationFloor;
            }
        }
        public EventItem(KindOfEvent kindOfEvent, float turnOnFireAlarmTime, float durationTimeFireAlarm)
        {
            KindOfEvent = kindOfEvent;
            TimeMarkers = new float[2];

            if (KindOfEvent == KindOfEvent.FireAlarm)
            {
                TimeMarkers[0] = turnOnFireAlarmTime;
                TimeMarkers[1] = durationTimeFireAlarm;
            }
        }
    }
}
