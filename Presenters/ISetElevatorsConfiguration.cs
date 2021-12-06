using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ISetElevatorsConfiguration : IView
    {
        event Action EndLiftsConfiguration;
        event Action SetElevatorsConfigurationClosing;
    }
}
