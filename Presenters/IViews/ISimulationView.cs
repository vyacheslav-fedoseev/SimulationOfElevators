using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface ISimulationView : IView
    {
        event Action SimulationClosed;
        event Action CreatePeople;
        event Action CheckPeopleStatus;
        event Action Stop;
        event Action PlayPause;
        event Action SpeedUp;
        event Action SlowDown;
        event Action Fire;
        void ShowError(string message);
        void HideError();
        string PeopleCount { get; }
        string CurrentFloor { get; }
        string DestinationFloor { get; }
        void UpdateElevatorsGrid(bool[,] elevatorsGrid, string[] floorInfo);
        void UpdatePeopleStatusLabel(string peopleStatus);
        void UpdateView(bool[,] elevatorsGrid, string peopleStatus, string[] floorInfo);
    }
}
