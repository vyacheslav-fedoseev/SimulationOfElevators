using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Presenters.Common;

namespace Presenters.Presenters
{
    public class SimulationPresenter : BasePresenter<ISimulationView, IStartView>
    {
        private IStartView _previousView;
        public SimulationPresenter(IApplicationController controller, ISimulationView view)
            : base(controller, view)
        {
            View.Stop += () => Stop();
            View.PlayPause += () => PlayPause();
            View.Fire += () => Fire();
            View.CheckPeopleStatus += () => CheckPeopleStatus();
            View.SlowDown += () => SlowDown();
            View.SpeedUp += () => SpeedUp();
            View.SimulationClosed += () => SimulationClosed();
            View.CreatePeople += () => CreatePeople();
        }
        private void Stop()
        {
            View.Close();
            Controller.Run<StatisticsPresenter, IStartView>(_previousView);
        }
        private void PlayPause()
        {

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

        }
        private void SpeedUp()
        {

        }
        private void SimulationClosed()
        {
            View.Close();
            _previousView.Show();

        }
        private void CreatePeople()
        {
            Controller.Run<CreatePeoplePresenter>();
        }

        public override void Run(IStartView previousView)
        {
            _previousView = previousView;
            View.Show();
        }
        /*
private void StartConfiguration()
{
   Controller.Run<SetConfigurationPresenter>();
}
*/
    }
}
