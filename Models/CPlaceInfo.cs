using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal abstract class CPlaceInfo
    {
        protected int number;
        protected Queue<CPeople> people;
    }
}
