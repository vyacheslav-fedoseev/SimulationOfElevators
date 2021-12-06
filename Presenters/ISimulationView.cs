using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ISimulationView: IView
    {
        event Action SimulationClosed;
        event Action CreatePeople;
        event Action CheckPeopleStatus;
        event Action Stop;
        event Action PlayPause;
        event Action SpeedUp;
        event Action SlowDown;
        event Action Fire;
    }
}
