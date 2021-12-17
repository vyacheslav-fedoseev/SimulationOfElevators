using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Presenters.Common;
using Models.Services;

namespace Presenters.Presenters
{
    public class StatisticsPresenter : BasePresenter<IStatisticsView, IStartView>
    {
        private IStartView _previousView;
        private IStatisticsService _statisticsService;
        public StatisticsPresenter(IApplicationController controller, IStatisticsView view, IStatisticsService statisticsService)
            : base(controller, view)
        {
            _statisticsService = statisticsService;
            View.Exit += Exit;
            View.StatisticClosing += StatisticsClosing;
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
            View.ShowStatistics(_statisticsService.GetStatistcs());
            View.Show(); 
        }
    }

}
