using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface ICheckPeopleStatusView : IView
    {
        event Action CloseProgram;
        void UpdateView(string peopleStatusList);
    }
}
