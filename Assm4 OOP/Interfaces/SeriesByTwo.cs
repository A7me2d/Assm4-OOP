﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Interfaces
{
    internal class SeriesByTwo : ISerris
    {
        public int Current {  get; set; }

        public void GetNext()
        {
            Current = 2;
        }



    }
}
