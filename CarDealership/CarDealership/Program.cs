using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

           
            List<Car> cars = new List<Car>();

            //cars.Add(new Car { make = "Ford", model = "Focus", price = 15000 });
           // cars.Add(new Car { make = "Ford", model = "Fiesta", price = 9000 });
           // cars.Add(new Car { make = "Ford", model = "Kuga", price = 21000 });

            Car myCar1 = new Car("Ford", "Focus", 15000);
            
            cars.Add(myCar1);

            Car myCar2 = new Car("Ford", "Fiesta", 9000);
            
            myCar2.SellCar(true, 20000);
            cars.Add(myCar2);

            Car myCar3 = new Car("Ford", "Kuga", 21000);
            
            cars.Add(myCar3);

            Car myCar4 = new Car("Toyota", "Rav 4", 35000, 10000, 3);
            cars.Add(myCar4);



            Console.WriteLine("----------------------");

            Car.ListCars(cars);
            Console.WriteLine("----------------------");
            Car.ValueInStock(cars);
            Console.WriteLine("----------------------");
            //Car.ListCarDetails(cars);
            Console.WriteLine("----------------------");


            //foreach (var car in cars)
            //{
            //    Console.WriteLine("Make: {0}\nModel: {1}\nPrice: {2}",car.make, car.model, car.price);
            //}

            //Console.WriteLine(myCar1.DisplayCar());
            Console.WriteLine(Car.totalCars);

        }
    }
}
