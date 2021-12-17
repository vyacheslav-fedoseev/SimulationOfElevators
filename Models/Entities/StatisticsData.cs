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
        public List<float> PercentOfIdleRides;
        public int TotalCountOfPeople;
        public int TotalCountOfRides;
        public float PeopleWaitingTime;
        public float AveragePeopleWaitingTime;
        public float MaxPeopleWaitingTime;
        public int CountOfFireAlarms;
        public float FireAlarmsTime;

    }
}
