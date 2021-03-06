using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Presenters.Common;
using Presenters.IViews;
using Models.Services;

namespace Presenters.Presenters
{
    public class CreateEventsListPresenter : BasePresenter<ICreateEventsListView>
    {
        private readonly IEventsListService _eventsListService;
        private readonly ILoadService<EventItem> _loadService;

        public CreateEventsListPresenter(IApplicationController controller, ICreateEventsListView view, IEventsListService eventsListService, ILoadService<EventItem> loadService)
            : base(controller, view)
        {
            _eventsListService = eventsListService;
            _loadService = loadService;
            View.CreateFireAlarm += () =>
                CreateFireAlarm(View.TurnOnFireAlarmTime, View.DurationTimeFireAlarm);
            View.CreatePeople += () =>
                CreatePeople(View.PeopleCount, View.CurrentFloor, View.DestinationFloor, View.CreatePeopleTime);
            View.OK += Ok;
            View.Import += Import;
            View.Export += Export;
        }


        private void Import()
        {
            var address = View.ImportAddress();
            if (address != null)
                _loadService.Import(address);

        }

        private void Export() => _loadService.Export(View.ExportAddress());


        private void CreateFireAlarm(string turnOnFireAlarmTime, string durationTimeFireAlarm)
        {
            if (turnOnFireAlarmTime != string.Empty && durationTimeFireAlarm != string.Empty)
            {
                View.HideFireAlarmError();
                var turnOnFireAlarmTimeInt = float.Parse(turnOnFireAlarmTime);
                var durationTimeFireAlarmInt = float.Parse(durationTimeFireAlarm);
                
                View.AddEventInList("ПОЖАРНАЯ ТРЕВОГА: " +
                                    $"включить на {turnOnFireAlarmTime} секунде. " +
                                    $"Длительность: {durationTimeFireAlarm} секунд.");

                _eventsListService.AddFireAlarmEvent(turnOnFireAlarmTimeInt, durationTimeFireAlarmInt);
                return;
            }
            View.ShowErrorFireAlarm("Некорректные данные!");

        }

        private void CreatePeople(string peopleCount, string currentFloor, string destinationFloor,
            string createPeopleTime)
        {
            if (peopleCount != string.Empty && currentFloor != string.Empty 
                                            && destinationFloor != string.Empty 
                                            && createPeopleTime != string.Empty)
            {
                View.HideCreatePeopleError();
                var peopleCountInt = int.Parse(peopleCount);
                var currentFloorInt = int.Parse(currentFloor);
                var destinationFloorInt = int.Parse(destinationFloor);
                var createPeopleTimeInt = int.Parse(createPeopleTime);
                
                View.AddEventInList("СОЗДАНИЕ ЛЮДЕЙ: " +
                                    $"{peopleCount} человек, следующих с {currentFloor} " +
                                    $"на {destinationFloor} этаж на {createPeopleTime} секунде.");

                _eventsListService.AddCreatePeopleEvent(peopleCountInt, currentFloorInt, destinationFloorInt, createPeopleTimeInt);
                return;
            }
            View.ShowErrorCreatePeople("Некорректные данные!");

        }

        private void Ok()
        {
            _eventsListService.SortListOfEvents();
            View.Close();
        }
    }
}
