using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class CPlaceInfo
    {
        protected int _number;
        protected Queue<CPeople> _people;
    }
}
