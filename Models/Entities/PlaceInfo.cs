using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public abstract class PlaceInfo
    {
        protected int _id { get; set; }
        protected Queue<People> _people;
    }
}
