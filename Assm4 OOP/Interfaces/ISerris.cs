using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Interfaces
{
    internal class ISerris
    {
        public int Current { get; set; }

        public void GetNext();
      
        public void Reset()
        {
            Current = 0;
        }
    }
}
