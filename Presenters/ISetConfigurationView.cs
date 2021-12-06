using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ISetConfigurationView : IView 
    {
        event Action Next;
    }
}
