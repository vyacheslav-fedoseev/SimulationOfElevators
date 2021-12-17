using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface ICreateEventsListView : IView
    {
        event Action CreatePeople;
        event Action CreateFireAlarm;
        event Action OK;
        event Action Import;
        event Action Export;

        string PeopleCount { get; }

        string CurrentFloor { get; }

        string DestinationFloor { get; }

        string CreatePeopleTime { get; }

        string TurnOnFireAlarmTime { get; }

        string DurationTimeFireAlarm { get; }

        void ShowErrorCreatePeople(string message);

        void ShowErrorFireAlarm(string message);

        void HideCreatePeopleError();

        void HideFireAlarmError();

        void AddEventInList(string eventData);

        string ExportAddress();

        string ImportAddress();
    }
}