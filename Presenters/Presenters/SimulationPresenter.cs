using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Presenters.Common;
using Models.Entities;
using Models.Services;

namespace Presenters.Presenters
{
    public class SimulationPresenter : BasePresenter<ISimulationView, IStartView>
    {
        private IStartView _previousView;
        private readonly IElevatorsManager _manager;
        private readonly IPeopleService _peopleService;
        private readonly IFloorService _floorService;

        public SimulationPresenter(IApplicationController controller, ISimulationView view, IElevatorsManager manager, IPeopleService peopleService, IFloorService floorService)
            : base(controller, view)
        {
            _manager = manager;
            _peopleService = peopleService;
            _floorService = floorService;
            View.Stop += Stop;
            View.PlayPause += PlayPause;
            View.Fire += Fire;
            //View.CheckPeopleStatus += CheckPeopleStatus;
            View.SlowDown += SlowDown;
            View.SpeedUp += SpeedUp;
            View.SimulationClosed += SimulationClosed;
            View.CreatePeople += () => Create(View.PeopleCount, View.CurrentFloor, View.DestinationFloor);
            _manager.DataUpdated += () => UpdateView(manager.GetElevatorsGrid(), _peopleService.GetPeopleStatus(), _floorService.GetFloorInfo(), _manager.GetTime());
            View.UpdateElevatorsGrid(new bool[ConfigurationData.CountFloors, ConfigurationData.CountElevators], _floorService.GetFloorInfo());
            manager.StartSimulation();
            peopleService.StartThread();
        }

        private void UpdateView(bool[,] elevatorsGrid, string peopleStatus, string[] floorInfo, float time) => View.UpdateView(elevatorsGrid, peopleStatus, floorInfo, time);
        public void Create(string countPeople, string currentFloor, string destinationFloor)
        {
            if (countPeople != string.Empty && currentFloor != string.Empty &&
                destinationFloor != string.Empty && currentFloor != destinationFloor)
            {
                View.HideError();
                var countPeopleInt = int.Parse(countPeople);
                var currentFloorInt = int.Parse(currentFloor);
                var destinationFloorInt = int.Parse(destinationFloor);

                if (!_peopleService.CreatePeople(countPeopleInt, currentFloorInt, destinationFloorInt))
                    View.ShowError("Этаж введен неверно");
            }
            else
                View.ShowError("Данные введены некорректно");
        }
        private void Stop()
        {
            _manager.StopSimulation();
            _peopleService.StopThread();
            View.Close();
            Controller.Run<StatisticsPresenter, IStartView>(_previousView);
        }

        private void PlayPause()
        {
            _manager.PlayPauseSimulation();
            _peopleService.PlayPauseThread();
        }

        private void Fire()
        {
            if (!_manager.Fire())
                View.ShowError("Люди еще не покинули здание");
            else
                View.HideError();
        }

        //private void CheckPeopleStatus() => Controller.Run<CheckPeopleStatusPresenter>();

        private void SlowDown()
        {
            _manager.SlowDown();
        }

        private void SpeedUp()
        {
            _manager.SpeedUp();
        }

        private void SimulationClosed()
        {
            _manager.StopSimulation();
            _peopleService.StopThread();
            View.Close();
            _previousView.Show();

        }

        public override void Run(IStartView previousView)
        {
            _previousView = previousView;
            View.Show();
        }
    }
}
