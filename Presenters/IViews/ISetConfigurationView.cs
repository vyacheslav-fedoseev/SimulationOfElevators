using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface ISetConfigurationView : IView 
    {
        event Action Next;
        string ElevatorsCount { get; }
        string FloorsCount { get; }

        void ShowError(string message);
        void HideError();
    }
}
