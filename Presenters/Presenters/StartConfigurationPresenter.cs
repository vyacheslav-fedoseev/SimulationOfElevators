using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;
using Presenters.IViews;

namespace Presenters.Presenters
{
    public class StartConfigurationPresenter : BasePresenter<IStartConfigurationView>
    {
        public StartConfigurationPresenter(IApplicationController controller, IStartConfigurationView view)
            : base(controller, view)
        {
            View.Ok += () => OK();
            View.StartConfiguration += () => StartConfiguration();
        }
        private void OK()
        {
            View.Close();
        }

        private void StartConfiguration()
        {

        }
    }
}
