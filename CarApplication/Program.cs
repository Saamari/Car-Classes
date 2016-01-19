using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one Car instance
            Car car = new Car();
            car.Model = "Audi";
            car.Color = "Black";
            car.Engine = 2.0;
            car.FuzzyDices = false;
            car.Speed = 100;
            car.PrintData();
                
            //Console.WriteLine("FuzzyDices = " + car.FuzzyDices);
            //Console.WriteLine("Model = " + car.Model);

            Car nascar = new Car("Toyota");
           
            nascar.Speed = 200;
            nascar.Color = "red";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.Accelerate(50);
            nascar.PrintData();
            nascar.Accelerate(50);
            nascar.PrintData();




            Console.ReadLine();
        }
    }
}
