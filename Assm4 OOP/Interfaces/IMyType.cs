using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Interfaces
{
     interface IMyType
    {
        public int Id { get; set; }

        public void MyFyn(int x);

        public void Print()
        {
            Console.WriteLine("Hello Default Implemented Method From Interfaces");
        }

    }
}
