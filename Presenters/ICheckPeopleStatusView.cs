﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface ICheckPeopleStatusView : IView
    {
        event Action CloseProgram;
    }
}
