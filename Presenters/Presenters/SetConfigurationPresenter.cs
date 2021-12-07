using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;
using Presenters.IViews;

namespace Presenters.Presenters
{
    class SetConfigurationPresenter: BasePresenter<ISetConfigurationView>
    {
        public SetConfigurationPresenter(IApplicationController controller, ISetConfigurationView view)
            : base(controller, view)
        {
            View.Next += () => Next();
        }
        private void Next()
        {
            //Controller.Run<SetElevatorsConfigurationPresenter, ISetConfigurationView>(this.View);
            Controller.Run<SetElevatorsConfigurationPresenter, ISetConfigurationView>(this.View);
        }
    }
}
