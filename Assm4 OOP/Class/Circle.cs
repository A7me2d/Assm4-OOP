using Assm4_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_OOP.Class
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public Circle(double radius) {

            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle\nRadius: {Radius}\nArea: {Area}");
        }
    }
}   
