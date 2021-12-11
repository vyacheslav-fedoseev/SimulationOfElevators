using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface IStartView : IView
    {
        event Action CreateEventsList;
        event Action StartSimulation;
        event Action StrategyChoosing;
        event Action Exit;
        event Action StartConfiguration;

        void ShowError(string message);
        void HideError();

    }
}
