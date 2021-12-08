using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Presenters.Common;

namespace Presenters.Presenters
{
    class CreatePeoplePresenter : BasePresenter<ICreatePeopleView>
    {
        public CreatePeoplePresenter(IApplicationController controller, ICreatePeopleView view)
            : base(controller, view)
        {
            View.Create += () => Create();
        }
        public void Create()
        {
            // View.Close();
        }
    }
}
