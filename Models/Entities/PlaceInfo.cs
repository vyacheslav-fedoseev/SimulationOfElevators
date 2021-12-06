﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public abstract class PlaceInfo
    {
        protected int _id;
        public int _ID
        {
            get
            {
                return _id;
            }
        }
        protected Queue<People> _people;
    }
}