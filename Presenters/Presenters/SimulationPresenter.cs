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

        public SimulationPresenter(IApplicationController controller, ISimulationView view, IElevatorsManager manager)
            : base(controller, view)
        {
            _manager = manager;
            View.Stop += Stop;
            View.PlayPause += PlayPause;
            View.Fire += Fire;
            View.CheckPeopleStatus += CheckPeopleStatus;
            View.SlowDown += SlowDown;
            View.SpeedUp += SpeedUp;
            View.SimulationClosed += SimulationClosed;
            View.CreatePeople += CreatePeople;
            _manager.DataUpdated += () => ViewUpdate(manager.GetElevatorsGrid());
            View.UpdateElevatorsGrid(new bool[ConfigurationData._countFloors, ConfigurationData._countElevators]);
            manager.StartSimulation();
        }

        private void ViewUpdate(bool[,] elevatorsGrid) => View.UpdateElevatorsGrid(elevatorsGrid);

        private void Stop()
        {
            _manager.StopSimulation();
            View.Close();
            Controller.Run<StatisticsPresenter, IStartView>(_previousView);
        }

        private void PlayPause()
        {
            _manager.PlayPauseSimulation();
        }

        private void Fire()
        {

        }

        private void CheckPeopleStatus()
        {
            Controller.Run<CheckPeopleStatusPresenter>();
        }

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
            View.Close();
            _previousView.Show();

        }

        private void CreatePeople() => Controller.Run<CreatePeoplePresenter>();

        public override void Run(IStartView previousView)
        {
            _previousView = previousView;
            View.Show();
        }
    }
}
