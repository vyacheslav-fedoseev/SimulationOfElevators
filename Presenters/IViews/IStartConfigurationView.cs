using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.Common;

namespace Presenters.IViews
{
    public interface IStartConfigurationView : IView
    {
        event Action Ok;
        event Action StartConfiguration;
    }
}
