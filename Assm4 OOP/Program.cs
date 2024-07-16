using Assm4_OOP.Interfaces;

namespace Assm4_OOP
{
    internal class Program
    {
        public static void Print10NumberFromSeries(ISerris series)
        {
            if (series is not null) {

                for (int i = 0; i < 10; i++) {
                    Console.WriteLine($"{series.Current}");
                    series.GetNext();
                }
                series.Reset();
            
            }
            
            }
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

            #region

            #endregion

            #region

            #endregion

            #region

            #endregion


        }
    }
}
