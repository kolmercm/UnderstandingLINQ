using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
            new Car() { VIN="A1", Make="BMW", Moddel="550i", StcikerPrice=55000, Year="1999" },
            new Car() { VIN = "B2", Make = "4Runner", Moddel = "SUV", StcikerPrice = 55000, Year = "1999" },
            new Car() { VIN = "C3", Make = "BMW", Moddel = "300", StcikerPrice = 35000, Year = "2011" },
            new Car() { VIN = "D4", Make = "Ford", Moddel = "Escape", StcikerPrice = 25000, Year = "2006" },
            new Car() { VIN = "E5", Make = "BMW", Moddel = "55i", StcikerPrice = 57000, Year = "2010" },
            };


    // Two sperate LINQ methods LINQ QUERY AND METHOD         

            //LINQ query 
            var bmws = from car in myCars
                       where car.Make =="BMW"
                       && car.Year ==2010
                       //&& must fill this operation and this operation.
                       select car

               
            //LINQ method

            var BMWs = myCars.Where(p => p.Make == "BMW" && p.Year == "2010");
            
            //add the method your calling to the subset BMW. Create a collection, start with previous collection, put something it it depending on criteria, we are picking something where the item has a certain property BMW and that item has a certain year. You need var bmws so LINQ knows what you are refferring too.

            var ordererdCars = from car in myCars
                            orderby car.Year desecnding
                select car;

              //Or//
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            // given each item in p we want to order by Year
            //Or//
            var firstBMW = myCars.First(p => p.Make = "BMW");
            // Order by First

            //Together//
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);
            //Chaining the two together



     
    // running through cars

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));
            //Are all cars greater than 2012?
            // checks through every car

            //Otherwise foreach

            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
            //another example
            myCars.ForEach(p => p.StickerPrice -= 3000);
            //or
           Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            // another aggregiate 
            Console.WriteLine(myCars.Sum(p=> p.StickerPrice));

            Console.WriteLine(myCars.GetType());
            // defines method called get type which will tell you the type of a given object printed to screen.










            foreach (var item in bmws)
            {
                Console.WriteLine("{0}, {1}", car.Year, car.Model, car.VIN);
            }
            Console.ReadLine();
        }
    }
}
