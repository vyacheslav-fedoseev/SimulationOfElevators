using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface IStatisticsView : IView
    {
        event Action Exit;
        event Action StatisticClosing;
        void ShowStatistics(string statistics);
    }
}
