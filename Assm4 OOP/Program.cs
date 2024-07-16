using Assm4_OOP.Interfaces;

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

            #region

            #endregion

            #region

            #endregion

            #region

            #endregion


        }
    }
}
