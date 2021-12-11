using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;
using Presenters.IViews;

namespace Presenters.Presenters
{
    public class StrategyChoosingPresenter : BasePresenter<IStrategyChoosingView>
    {
        public StrategyChoosingPresenter(IApplicationController controller, IStrategyChoosingView view) : base(controller, view)
        {
            View.Ok += Ok;
        }

        private void Ok() => View.Close();
    }
}
