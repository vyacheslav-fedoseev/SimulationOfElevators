using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IStartConfigurationView: IView
    {
        event Action Ok;
        event Action StartConfiguration;
    }
}
