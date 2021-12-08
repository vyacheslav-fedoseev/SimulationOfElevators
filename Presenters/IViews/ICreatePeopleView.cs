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

        string  peopleCount { get; }
        string currentFloor { get; }
        string destinationFloor { get; }
        void ShowError(string message);
        void HideError();
    }
}
