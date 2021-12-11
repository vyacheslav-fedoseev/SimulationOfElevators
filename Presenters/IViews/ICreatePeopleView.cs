using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface ICreatePeopleView : IView
    {
        event Action Create;
        string PeopleCount { get; }
        string CurrentFloor { get; }
        string DestinationFloor { get; }

        void ShowError(string message);
        void HideError();
    }
}
