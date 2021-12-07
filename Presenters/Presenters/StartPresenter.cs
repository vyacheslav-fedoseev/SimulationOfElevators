using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Presenters.IViews;
using Presenters.Common;

namespace Presenters.Presenters
{
    public class StartPresenter : BasePresenter<IStartView>
    {

        public StartPresenter(IApplicationController controller, IStartView view) : base(controller, view)
        {
            View.StartConfiguration += () => StartConfiguration();
            View.StrategyChoosing += () => StrategyChoosing();
            View.StartSimulation += () => StartSimulation();
            View.Exit += () => Exit();
        }
        private void StartConfiguration()
        {
            Controller.Run<StartConfigurationPresenter>();
        }

        private void StrategyChoosing()
        {
            Controller.Run<StrategyChoosingPresenter>();
        }
        private void StartSimulation()
        {
            View.Hide();
            Controller.Run<SimulationPresenter, IStartView>(this.View);
        }
        private void Exit()
        {
            View.Close();
        }
    }
}
