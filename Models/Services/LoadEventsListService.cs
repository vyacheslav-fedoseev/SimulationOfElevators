using System;
using System.Collections.Generic;
using System.IO;
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
            var strinfo = File.ReadAllLines(importAddress).ToList();

            foreach (var el in strinfo.Select(lines => lines.Split(' ')))
            {
                if (el[0] == "0")
                {
                    EventsListService._listOfEvents.Add(new 
                        EventItem(KindOfEvent.CreatePeople, int.Parse(el[1]), int.Parse(el[2]),
                            int.Parse(el[3]), float.Parse(el[0])));
                }
                if (el[0] == "1")
                {
                    EventsListService._listOfEvents.Add(new 
                        EventItem(KindOfEvent.FireAlarm, float.Parse(el[0]), float.Parse(el[1])));
                }
            }

            
            EventsListService._listOfEvents.Add(new EventItem(KindOfEvent.CreatePeople, 13, 3,
                10,
                7f));
            //EventsListService._listOfEvents.Add(new EventItem(KindOfEvent.FireAlarm, turnOnFireAlarmTime, turnOnFireAlarmTime));
        }

        public void Export(string exportAddress)
        {
            string strInfo = null;
            foreach (var element in EventsListService._listOfEvents)
            {
                if (element.KindOfEvent == KindOfEvent.CreatePeople)
                {
                    strInfo += $"{(int)element.KindOfEvent} " +
                               $"{element.Parameters[0]} " +
                               $"{element.Parameters[1]} " +
                               $"{element.Parameters[2]} " +
                               $"{element.TimeMarkers[0]}\n";
                }
                if (element.KindOfEvent == KindOfEvent.FireAlarm)
                {
                    strInfo += $"{(int)element.KindOfEvent} " +
                               $"{element.TimeMarkers[0]} " +
                               $"{element.TimeMarkers[1]}\n";
                }
            }
            File.WriteAllText(exportAddress ?? "EventsList.txt", strInfo);
        }
    }
}