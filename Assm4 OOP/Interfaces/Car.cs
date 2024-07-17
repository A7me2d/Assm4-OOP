using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Interfaces
{
    internal class Car : Vehicle, IMoveble
    {
        public void Backward()
        {
            Console.WriteLine("Car move back");
        }

        public void Forwerd()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
