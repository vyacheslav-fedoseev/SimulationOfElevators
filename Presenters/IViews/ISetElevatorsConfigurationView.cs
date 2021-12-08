using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface ISetElevatorsConfigurationView : IView
    {
        event Action EndLiftsConfiguration;
        event Action SetElevatorsConfigurationClosing;
        event Action AddElevator;

        void ShowError(string message);
        void HideError();

        string maxSpeed{get; }
        string maxAcceleration { get; }
        string capacity { get; }
        bool isTemplate { get; }
    }
}
