using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Interfaces
{
    internal class Airplane : Vehicle, IMoveble, IFlyable
    {
        public void Backward()
        {
            Console.WriteLine("Plane move back");
        }

        void IMoveble.Backward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }

        void IMoveble.Forwerd()
        {
            Console.WriteLine("Plane move on Grund");
        }

        void IFlyable.Forwerd()
        {
            Console.WriteLine("Plane move on Air");
        }

        void IMoveble.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveble.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
