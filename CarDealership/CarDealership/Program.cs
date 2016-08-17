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

            bool isManualorAuto = true;
            string input = "";



            List<Car> cars = new List<Car>();
            List<Motorcycle> bikes = new List<Motorcycle>();

            Car myCar1 = new Car("Ford", "Focus", 15000, true);
            Motorcycle bike1 = new Motorcycle("Ducati", "Superbike", 20000, 433, 200);
            cars.Add(myCar1);
            bikes.Add(bike1);

            Car myCar2 = new Car("Ford", "Fiesta", 9000, false);
            Motorcycle bike2 = new Motorcycle("Honda", "Touring", 12000, 500, 180);
            cars.Add(myCar2);
            bikes.Add(bike2);

            Car myCar3 = new Car("Ford", "Kuga", 21000, false);
            Motorcycle bike3 = new Motorcycle("BMW Motorcycles", "Rubbish", 15000, 450, 220);
            cars.Add(myCar3);
            bikes.Add(bike3);



            while (input != "0") {

                
                Console.WriteLine("Please Press the corresponding number: ");
                Console.WriteLine("Press 1 to add a car: ");
                Console.WriteLine("Press 2 to display all cars: ");
                Console.WriteLine("Press 3 to see the value of stock(cars): ");
                Console.WriteLine("Press 4 to add a motorcycle: ");
                Console.WriteLine("Press 5 to display all motorcycles: ");
                Console.WriteLine("Press 6 to see the value of stock(bikes): ");
                Console.WriteLine("Press 7 to Sell a car: ");
                Console.WriteLine("Press 8 to show vehicles sold: ");
                Console.WriteLine("Press 9 to Sell a bike: ");
                Console.WriteLine("Press 0 to exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter The Make: ");
                        string makeInput = Console.ReadLine();
                        Console.WriteLine("Enter The Model: ");
                        string modelInput = Console.ReadLine();
                        Console.WriteLine("Enter The Price: ");
                        int priceInput = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter if Manual(y/n): ");
                        string isManual = Console.ReadLine().ToLower();
                        if (isManual == "y")
                        {
                            isManualorAuto = true;
                        }
                        else if (isManual == "n")
                        {
                            isManualorAuto = false;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }

                        cars.Add(new Car(makeInput, modelInput, priceInput, isManualorAuto));
                        break;

                    case "2":
                        Console.Clear();
                        Car.ListCars(cars);
                        break;


                    case "3":
                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Car.ValueInStock(cars);
                        Console.WriteLine("----------------------");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter The Make: ");
                        makeInput = Console.ReadLine();
                        Console.WriteLine("Enter The Model: ");
                        modelInput = Console.ReadLine();
                        Console.WriteLine("Enter The Price: ");
                        priceInput = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter The Weight: ");
                        int weightInput = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter The Maxspeed: ");
                        int speedInput = Int32.Parse(Console.ReadLine());


                        bikes.Add(new Motorcycle(makeInput, modelInput, priceInput, weightInput, speedInput));
                        break;

                    case "5":
                        Console.Clear();
                        Motorcycle.ListBikes(bikes);
                        break;


                    case "6":
                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Motorcycle.ValueInStock(bikes);
                        Console.WriteLine("----------------------");
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Enter the car Model to search: ");
                        string searchedCar = Console.ReadLine();
                        Console.WriteLine("Enter price the car sold for: ");
                        int sellPrice = Int32.Parse(Console.ReadLine());
                        Car result = cars.Find(x => x.model == searchedCar);

                        result.SellCar(true, sellPrice);
                        

                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Enter the motorcycle Model to search: ");
                        string searchedBike = Console.ReadLine();
                        Console.WriteLine("Enter price the motorcycle sold for: ");
                        int sellBikePrice = Int32.Parse(Console.ReadLine());
                        Motorcycle resultBike = bikes.Find(x => x.model == searchedBike);

                        resultBike.SellBike(true, sellBikePrice);
                        break;
                    case "8":
                        Console.Clear();
                        Car.ListSoldCars(cars);
                        Motorcycle.ListSoldBikes(bikes);
                        break;

                    case "0":
                        break;

                    default:
                        
                        Console.WriteLine("Please Press the corresponding number: ");
                        Console.WriteLine("Press 1 to add a car: ");
                        Console.WriteLine("Press 2 to display all cars: ");
                        Console.WriteLine("Press 3 to see the value of stock(cars): ");
                        Console.WriteLine("Press 4 to add a motorcycle: ");
                        Console.WriteLine("Press 5 to display all motorcycles: ");
                        Console.WriteLine("Press 6 to see the value of stock(bikes): ");
                        Console.WriteLine("Press 7 to Sell a car: ");
                        Console.WriteLine("Press 8 to show cars sold: ");
                        Console.WriteLine("Press 9 to Sell a bike: ");
                        Console.WriteLine("Press 0 to exit");
                        input = Console.ReadLine();
                        break;
                }
                
            

            }




            //List<Motorcycle> bikes = new List<Motorcycle>();



            //cars.Add(new Car { make = "Ford", model = "Focus", price = 15000 });
            //cars.Add(new Car { make = "Ford", model = "Fiesta", price = 9000 });
            //cars.Add(new Car { make = "Ford", model = "Kuga", price = 21000 });

            //Car myCar1 = new Car("Ford", "Focus", 15000, true);
            //Motorcycle bike1 = new Motorcycle("Ducati", "Superbike", 20000, 433, 200);
            //cars.Add(myCar1);
            //bikes.Add(bike1);

            //Car myCar2 = new Car("Ford", "Fiesta", 9000, false);
            //Motorcycle bike2 = new Motorcycle("Honda", "Touring", 12000, 500, 180);
            //cars.Add(myCar2);
            //bikes.Add(bike2);

            //Car myCar3 = new Car("Ford", "Kuga", 21000, false);
            //Motorcycle bike3 = new Motorcycle("BMW Motorcycles", "Rubbish", 15000, 450, 220);
            //cars.Add(myCar3);
            //bikes.Add(bike3);

            //Car myCar4 = new Car("Toyota", "Rav 4", 35000, false, 10000, 3);

            //cars.Add(myCar4);



            //Console.WriteLine("----------------------");

            //Car.ListCars(cars);
            //Console.WriteLine("----------------------");
            //Motorcycle.ListBikes(bikes);
            //Console.WriteLine("----------------------");
            //Car.ValueInStock(cars);
            //Console.WriteLine("----------------------");
            //Motorcycle.ValueInStock(bikes);
            //Console.WriteLine("----------------------");
            //Car.ListCarDetails(cars);
            //Console.WriteLine("----------------------");


            ////foreach (var car in cars)
            ////{
            ////    Console.WriteLine("Make: {0}\nModel: {1}\nPrice: {2}",car.make, car.model, car.price);
            ////}

            ////Console.WriteLine(myCar1.DisplayCar());
            //Console.WriteLine("Number of cars in stock: " + Car.totalCars);
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Number of bikes in stock: " + Motorcycle.totalMotorbikes);

        }
    }
}
