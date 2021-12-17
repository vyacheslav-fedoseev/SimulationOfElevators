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
 
        public StatisticsService()
        {
            InitializeStatistics();
        }

        public void IncrementCountOfRides(int id)
        {
            _statisticsData.CountOfRides[id - 1]++;
            _statisticsData.TotalCountOfRides++;
        }
        public void IncrementCountOfFireAlarms() => _statisticsData.CountOfFireAlarms++;

        public void IncrementCountOfPeople(int id) => _statisticsData.CountOfPeople[id-1]++;

        public string GetStatistcs()
        {
            var statistics = string.Empty;

            statistics += $@"Общее количество поездок      {_statisticsData.TotalCountOfRides}
Количество пожарных тревог       {_statisticsData.CountOfFireAlarms}
Суммарная длительность тревог    { _statisticsData.FireAlarmsTime }
Среднее время ожидания лифтов    {_statisticsData.AveragePeopleWaitingTime}
Наибольшее время ожидания лифтов { _statisticsData.MaxPeopleWaitingTime}
Суммарное время ожидания лифтов  { _statisticsData.PeopleWaitingTime}
Номер лифта                                  ";

            for(var i=0; i < ConfigurationData._countElevators; i++)
            {
                statistics += $"         {i + 1}";     
            }
            statistics += "\nОбщее количество поездок          ";
            for (var i = 0; i < ConfigurationData._countElevators; i++)
            {
                statistics += $"         {_statisticsData.CountOfRides[i]}";
            }
            statistics += "\nПроцент холостых поездок           ";
            for (var i = 0; i < ConfigurationData._countElevators; i++)
            {
                statistics += $"         {_statisticsData.IdleRides[i]}";
            }
            statistics += "\nКоличество перевезенных людей ";
            for (var i = 0; i < ConfigurationData._countElevators; i++)
            {
                statistics += $"         {_statisticsData.CountOfPeople[i]}";
            }
            ClearStatistics();

            return statistics;
        }

        private void InitializeStatistics()
        {
            if (ConfigurationData._countElevators == 0 || _statisticsData.CountOfRides != null && _statisticsData.CountOfRides.Count != 0) return;
            _statisticsData.CountOfRides = new List<int>();
            _statisticsData.IdleRides = new List<int>();
            _statisticsData.CountOfPeople = new List<int>();

            for (var i = 0; i < ConfigurationData._countElevators; i++)
            {
                _statisticsData.CountOfRides.Add(0);
                _statisticsData.IdleRides.Add(0);
                _statisticsData.CountOfPeople.Add(0);
            }

            _statisticsData.TotalCountOfPeople = 0;
            _statisticsData.TotalCountOfRides = 0;
            _statisticsData.PeopleWaitingTime = 0;
            _statisticsData.AveragePeopleWaitingTime = 0;
            _statisticsData.MaxPeopleWaitingTime = 0;
            _statisticsData.CountOfFireAlarms = 0;
            _statisticsData.FireAlarmsTime = 0;
        }
        private void ClearStatistics()
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
