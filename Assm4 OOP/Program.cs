﻿using Assm4_OOP.ICloneblae_Interface;
using Assm4_OOP.Interfaces;
using System.Text;

namespace Assm4_OOP
{
    internal class Program
    {
        //public static void Print10NumberFromSeries(ISerris series)
        //{
        //    if (series is not null) {

        //        for (int i = 0; i < 10; i++) {
        //            Console.WriteLine($"{series.Current}");
        //            series.GetNext();
        //        }
        //        series.Reset();
            
        //    }
            
        //    }
        static void Main(string[] args)
        {


            #region Interfaces

            //IMyType myType = new IMyType();

            //IMyType myType;

            //myType.Id = 20;
            //myType.MyFyn();
            //myType.Print();


            //MyType myType1 = new MyType();

            //myType1.Id = 30;
            //myType1.MyFyn(100);
            //myType1.Print();

            //IMyType myType = new MyType();

            //myType.Id = 1;
            //myType.MyFyn(800);
            //myType.Print();



            #endregion

            #region Interface Ex 01

            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //Print10NumberFromSeries (seriesByTwo);


            //Console.WriteLine("\n===============");

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumberFromSeries(seriesByThree);


            //Console.WriteLine("\n===============");

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumberFromSeries(seriesByFour);



            #endregion

            #region Interface Ex 02

            //Car car = new Car();
            //car.Backward();


            //Airplane airplane = new Airplane();
            //airplane.Backward();
            ////airplane.Backward();

            //IMoveble movebleplane = new Airplane();
            //movebleplane.Forwerd();



            #endregion

            #region Shallow Copy And Deep Copy

            #region Arry of value type
            //int[] Arr02 = { 1, 2, 3 };
            //int[] Arr01 = new int[3];

            //Console.WriteLine($"HC OF Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC OF Arr02 = {Arr02.GetHashCode()}");




            #region Shallow Copy Stack

            //Arr01 = Arr02;
            //Console.WriteLine("\nAfter Shallow");

            //Console.Write($"HC OF Arr01 = {Arr01.GetHashCode()}");
            //Console.Write($"HC OF Arr02 = {Arr02.GetHashCode()}");


            //Console.Write($"Arr02 = {Arr02[0]}");
            //Console.Write($"Arr01 = {Arr01[0]}");

            //Arr02[0] = 100;

            //Console.WriteLine("\nAfter Arr02 = 100");

            //Console.Write($"Arr02 = {Arr02[0]}");
            //Console.Write($"Arr01 = {Arr01[0]}");
            #endregion


            #region Deep copy heap

            //Arr02 = (int[]) Arr01.Clone();

            //Console.WriteLine("\nAfter Deep Copy");

            //Console.WriteLine($"HC OF Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HC OF Arr02 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01 = {Arr01[0]}");
            //Console.WriteLine($"Arr02 = {Arr02[0]}");

            //Arr01[0] = 100;

            //Console.WriteLine("\nAfter Arr01 = 100");
            //Console.WriteLine($"Arr01 = {Arr01[0]}");
            //Console.WriteLine($"Arr02 = {Arr02[0]}");


            #endregion


            #endregion

            #endregion

            #region Array of Refrence Type

            #region Arry of String [Immutable Type]

            //string[] Names01 = { "Ahmed" };
            //string[] Names02 = new string[1];

            //Console.WriteLine($"HC of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 = {Names02.GetHashCode()}");


            #region Shallow Copy
            //Names02 = Names01;

            //Console.WriteLine("\nAfter Copy");
            //      Console.WriteLine($"HC of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Name01 = {Names01[0]}");
            //Console.WriteLine($"Name02 = {Names02[0]}");

            //Names02[0] = "Hany";

            //Console.WriteLine($"Name01 = {Names01[0]}");
            //Console.WriteLine($"Name02 = {Names02[0]}");
            #endregion

            #region Deep Copy

            //Names02 = (string[]) Names01.Clone();

            //Console.WriteLine("\nAfter Deep Copy");
            //Console.WriteLine($"HC of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Name01 = {Names01[0]}");
            //Console.WriteLine($"Name02 = {Names02[0]}");

            //Names02[0] = "Hany";
            //Console.WriteLine($"Name01 = {Names01[0]}");
            //Console.WriteLine($"Name02 = {Names02[0]}");
            #endregion



            #endregion

            #endregion

            #region Array of StringBuilder [Mutable type]

            //StringBuilder[] Name01 = new StringBuilder[1];
            //Name01[0] = new StringBuilder("Ahmed");

            //StringBuilder[] Name02 = new StringBuilder[1];


            //Console.WriteLine($"HC ofNames01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HC ofNames02 = {Name02.GetHashCode()}");

            #region Shallow Copy
            //Name02 = Name01;

            //Console.WriteLine("\nAfter Shallow Copy");
            //Console.WriteLine($"HC ofNames01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HC ofNames02 = {Name02.GetHashCode()}");


            //Name01 = Name02;
            //Console.WriteLine($"Name01 = {Name01[0]}");
            //Console.WriteLine($"Name02 = {Name02[0]}");
            #endregion


            #region Deep Copy [Heap]

            //Name02 = (StringBuilder[]) Name01.Clone();


            //Console.WriteLine("\nAfter Deep Copy");

            //Console.WriteLine($"HC ofNames01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HC ofNames02 = {Name02.GetHashCode()}");

            //Console.WriteLine($"Name01 = {Name01[0]}");
            //Console.WriteLine($"Name02 = {Name02[0]}");

            //Name02[0].Append("Hany");
            //Console.WriteLine($"Name01 = {Name01[0]}");
            //Console.WriteLine($"Name02 = {Name02[0]}");

            #endregion


            #endregion


            #region Shallow Copy and Deep Copy

            //Emploee employee01 = new Emploee() { Id = 10, Name = "Ahmed", Salary = 9000 };
            //Emploee employee02 = new Emploee() { Id = 20, Name = "Hany", Salary = 1200 };

            //Emploee employee01 = new Emploee() { Id = 10, Name = new StringBuilder("Ahmed"), Salary =  9000 };
            //Emploee employee02 = new Emploee() { Id = 20, Name = new StringBuilder("Hany") , Salary = 1200 };

            //Console.WriteLine($"HC OF Empo01 {employee01.GetHashCode()}");
            //Console.WriteLine($"Emp01 = {employee01}"); 


            //Console.WriteLine($"HC OF Empo02 {employee02.GetHashCode()}");
            //Console.WriteLine($"Emp02 = {employee02}");

            //employee01.Id = 100;
            //employee01.Name = "makram";
            //employee01.Salary = 12355;

            //Console.WriteLine("After Change Value");
            //Console.WriteLine($"Emp01 {employee01}");
            //Console.WriteLine($"Emp02 {employee02}");


            #region Shallow Copy And Deep Copy


            #region Shallow Copy [Stack]
            //employee02 = employee01;

            //Console.WriteLine("After Shalow Copy");

            //Console.WriteLine($"HC OF Empo01 {employee01.GetHashCode()}");
            //Console.WriteLine($"Emp01 = {employee01}"); 


            //Console.WriteLine($"HC OF Empo02 {employee02.GetHashCode()}");
            //Console.WriteLine($"Emp02 = {employee02}");

            //employee01.Id = 100;
            //employee01.Name.Append = ("hany");
            //employee01.Salary = 20000;


            //Console.WriteLine("=======After Changing Employee01 Values=====");
            //Console.WriteLine($"Emp01 = {employee01}"); 
            //Console.WriteLine($"Emp02 = {employee02}");




            #endregion

            #region Shallow Copy - Name is string builder

            //employee02 = employee01;

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HC OF Empo01 {employee01.GetHashCode()}");
            //Console.WriteLine($"Emp01 = {employee01}"); 


            //Console.WriteLine($"HC OF Empo02 {employee02.GetHashCode()}");
            //Console.WriteLine($"Emp02 = {employee02}");

            //employee01.Id = 100;
            //employee01.Name.Append = ("hany");
            //employee01.Salary = 20000;


            //Console.WriteLine("=======After Changing Employee01 Values=====");
            //Console.WriteLine($"Emp01 = {employee01}"); 
            //Console.WriteLine($"Emp02 = {employee02}");

            #endregion

            #region Deep copy - name is String

            //employee02  = (Emploee)employee01.Clone();

            //Console.WriteLine("After Deep Copy");

            //Console.WriteLine($"HC OF Empo01 {employee01.GetHashCode()}");
            //Console.WriteLine($"Emp01 = {employee01}");


            //Console.WriteLine($"HC OF Empo02 {employee02.GetHashCode()}");
            //Console.WriteLine($"Emp02 = {employee02}");

            //employee02.Id = 200;
            //employee02.Name = "Makram";
            //employee02.Salary = 30000;

            //Console.WriteLine("After Changing Employee02 values");
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);

            #endregion

            #region Deep Copy - name is StringBuilder
            //employee02 = (Emploee)employee01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC OF Empo01 {employee01.GetHashCode()}");
            //Console.WriteLine($"Emp01 = {employee01}");


            //Console.WriteLine($"HC OF Empo02 {employee02.GetHashCode()}");
            //Console.WriteLine($"Emp02 = {employee02}");

            //employee02.Id = 500;
            //employee02.Name.Append("Hany");
            //employee02.Salary = 6000;

            //Console.WriteLine("After Changing Employee02 Value");
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02);
            #endregion


            //employee02 = new Emploee(employee01);

            //Console.WriteLine("After Deep Copy");

            //Console.WriteLine($"HC OF Empo01 {employee01.GetHashCode()}");
            //Console.WriteLine($"Emp01 = {employee01}");


            //Console.WriteLine($"HC OF Empo02 {employee02.GetHashCode()}");
            //Console.WriteLine($"Emp02 = {employee02}");

            #endregion

            #endregion

            #region Built in Interface Icomareable
            //int[] Number = { 9, 6, 4, 8, 5, 3, 2, 7, 1, 10 };
            //Array.Sort(Number);

            //foreach (int Num in Number)
            //{
            //    Console.WriteLine(Num);
            //}

            //Emploee[] emploees = new Emploee[4]
            //{
            //    new Emploee(){Id = 10 , Name = "Ahmed" , Salary = 10000},
            //    new Emploee(){Id = 20 , Name = "Hany" , Salary = 20000},
            //    new Emploee(){Id = 30 , Name = "Makram" , Salary = 30000},
            //    new Emploee(){Id = 40 , Name = "Mohamed" , Salary = 40000}
            //};

            //Array.Sort(emploees , new EmployeeIdComparer());

            //for (int i = 0; i < emploees.Length; i++)
            //{
            //    for (int K = 0; K < emploees.Length - i - 1; K++)
            //    {
            //        if (emploees[K].CompareTo(emploees[K + 1 ]) == 1)
            //            SWAP(emploees[K], emploees[K + 1]);
            //    }
            //}




            //foreach (Emploee emp in emploees)
            //{
            //    Console.WriteLine(emp);
            //}

            //Console.WriteLine(emploees[0].CompareTo(emploees[1]));
            #endregion

        }
    }
}
