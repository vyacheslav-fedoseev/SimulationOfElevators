using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class StatisticsData
    {
        public List<int> CountOfRides;
        public List<int> IdleRides;
        public List<int> CountOfPeople;
        public int TotalCountOfPeople;
        public int TotalCountOfRides;
        public float PeopleWaitingTime;
        public float AveragePeopleWaitingTime;
        public float MaxPeopleWaitingTime;
        public int CountOfFireAlarms;
        public float FireAlarmsTime;

        public StatisticsData()
        {
            CountOfRides = new List<int>();
            IdleRides = new List<int>() ;
            CountOfPeople = new List<int>();

            for(var i=0; i< ConfigurationData._countElevators;i++)
            {
                CountOfRides.Add(0);
                IdleRides.Add(0);
                CountOfPeople.Add(0);
            }

             TotalCountOfPeople=0;
             TotalCountOfRides=0;
             PeopleWaitingTime=0;
             AveragePeopleWaitingTime=0;
             MaxPeopleWaitingTime=0;
             CountOfFireAlarms=0;
             FireAlarmsTime=0;
        }
    }
}
