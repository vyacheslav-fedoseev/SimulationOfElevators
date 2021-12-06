using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Presenters
{
    public class StartFormPresenter
    {
        private IStartView _view;

        public StartFormPresenter(IStartView view)
        {
            _view = view;
        }
    }
}
