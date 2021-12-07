using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Presenters.Common;

namespace Presenters.Presenters
{
    class StatisticsPresenter : BasePresenter<IStatisticsView, IStartView>
    {
        private IStartView _previousView;
        public StatisticsPresenter(IApplicationController controller, IStatisticsView view)
            : base(controller, view)
        {
            View.Exit += () => Exit();
            View.StatisticClosing += () => StatisticsClosing();
        }
        private void Exit()
        {
            View.Close();
            _previousView.Show();
        }
        private void StatisticsClosing()
        {
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
