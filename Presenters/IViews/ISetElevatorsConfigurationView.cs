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

        string MaxSpeed { get; }
        string MaxAcceleration { get; }
        string Capacity { get; }
        bool IsTemplate { get; }
    }
}
