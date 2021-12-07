using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Presenters.Common;

namespace Presenters.Presenters
{
    class CheckPeopleStatusPresenter : BasePresenter<ICheckPeopleStatusView>
    {
        public CheckPeopleStatusPresenter(IApplicationController controller, ICheckPeopleStatusView view)
            : base(controller, view)
        {
            View.CloseProgram += () => CloseProgram();
        }
        private void CloseProgram()
        {
            View.Close();
        }
    }
}
