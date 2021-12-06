using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IStartView : IView
    {
        event Action CreateEventsList;
        event Action StartSimulation;
        event Action StrategyChoosing;
        event Action Exit;
        event Action StartConfiguration;
    }
}
