using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Interfaces
{
    internal class MyType : IMyType
    {
        public int Id { get; set; }

        public void MyFyn(int x)
        {
            Console.WriteLine($"Hello Worled : X = {x} , Id = {Id}");
        }
    }
}
