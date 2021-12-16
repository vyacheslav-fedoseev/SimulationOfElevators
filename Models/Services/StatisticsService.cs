using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Services
{
    public class StatisticsService: IStatisticsService
    {
        private static StatisticsData _statisticsData = new StatisticsData();
        public string GetStatistcs()
        {
            return " ";
        }

        public void ClearStatistics()
        {
            _statisticsData.AveragePeopleWaitingTime = 0;
            _statisticsData.CountOfFireAlarms = 0;
            _statisticsData.CountOfPeople.Clear();
            _statisticsData.CountOfRides.Clear();
            _statisticsData.FireAlarmsTime = 0;
            _statisticsData.IdleRides.Clear();
            _statisticsData.MaxPeopleWaitingTime = 0;
            _statisticsData.TotalCountOfPeople = 0;
            _statisticsData.PeopleWaitingTime = 0;
            _statisticsData.TotalCountOfRides = 0;
        }
    }
}
