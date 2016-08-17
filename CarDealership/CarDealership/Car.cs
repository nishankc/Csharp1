using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Car : Vehicle
    {
        private string type;
        private bool manual;
        
        public static int totalCars;



        

        public Car(string make, string model, int price, bool manual) : base (make, model, price)
        {

            this.type = "Car";
            //this.make = make;
            //this.model = model;
            //this.price = price;
            this.manual = manual;
            this.sold = false;
            totalCars++;

        }

        public Car(string make, string model, int price,bool manual, int mileage, int yearsOld) : base(make, model, price, mileage, yearsOld)
        {
            this.type = "Car";
            //this.make = make;
            //this.model = model;
            //this.price = price;
            this.manual = manual;
            this.sold = false;
            this.mileage = mileage;
            this.yearsOld = yearsOld;
            totalCars++;

        }

        public override void Display()
        {


            Console.WriteLine("Make: " + Make + "\nModel: " + Model + "\nPrice: " + Price + "\nType" + manual);
        }

        public void SellCar(bool sold, int price)
        {
            this.sold = sold;
            this.Price = price;
        }


        public static void ListSoldCars(List<Car> cars)
        {
            string autoOrManual = "";

            foreach (var car in cars)
            {

                if (car.sold == true)
                {
                    if (car.manual != true)
                    {
                        autoOrManual = "Automatic";
                    }
                    else
                    {
                        autoOrManual = "Manual";
                    }

                    Console.WriteLine("Make: " + car.Make + "\nModel: " + car.Model + "\nPrice: " + car.Price + "\nType: " + autoOrManual);
                    Console.WriteLine("----------------------");
                }
                

                
            }
        }

        public static void ListCars(List<Car> cars)
        {
            int totalCar = totalCars;
            string autoOrManual = "";

            



            foreach (var car in cars)
            {
                
                if (car.sold != true)
                {
                    if(car.manual != true)
                    {
                        autoOrManual = "Automatic";
                    }else
                    {
                        autoOrManual = "Manual";
                    }

                    Console.WriteLine("Make: " + car.Make + "\nModel: " + car.Model + "\nPrice: " + car.Price + "\nType: " + autoOrManual);
                    Console.WriteLine("----------------------");
                }
                else
                {
                    totalCar--;
                }

                totalCars = totalCar;
            }
            
        }

        public static void ValueInStock(List<Car> cars)
        {
            int totalCost = 0;

            foreach(var car in cars)
            {
                if(car.sold != true)
                {
                    totalCost += car.Price;
                }
            }

            Console.WriteLine("Total Value of Stock for cars: {0}",totalCost);
        }

        public static void ListCarDetails(List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (car.sold != true && car.mileage != 0 && car.yearsOld != 0)
                {
                    Console.WriteLine("Make: " + car.Make + "\nModel: " + car.Model + "\nPrice: " + car.Price + "\nMileage: " + car.mileage + "\nThe car is {0} years old",car.yearsOld);
                }
                

            }
        }


    }
}
