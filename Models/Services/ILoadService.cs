using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface ILoadService<T>
    {
        void Import();
        void Export(string exportAddress);
    }
}
