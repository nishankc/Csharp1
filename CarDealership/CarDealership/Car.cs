using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Car
    {
        private string make;
        private string model;
        private int price;
        private bool sold;
        private int mileage;
        private int yearsOld;
        
        public static int totalCars;





        public Car(string make, string model, int price)
        {

            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            totalCars++;

        }

        public Car(string make, string model, int price, int mileage, int yearsOld)
        {

            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.mileage = mileage;
            this.yearsOld = yearsOld;
            totalCars++;

        }


        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        
        public bool Sold
        {
            get { return sold; }
            set { sold = value; }
        }

        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public int YearsOld
        {
            get { return yearsOld; }
            set { yearsOld = value; }
        }

        public string DisplayCar()
        {
            return "Make: " + Make + "\nModel: " + Model + "\nPrice: " + Price;
        }

       

        

        

        public void SellCar(bool sold, int price)
        {
            this.sold = sold;
            this.price = price;
        }

        public static void ListCars(List<Car> cars)
        {
            int totalCar = totalCars;
            foreach (var car in cars)
            {
                
                if (car.sold != true)
                {
                    Console.WriteLine("Make: " + car.make + "\nModel: " + car.model + "\nPrice: " + car.price);
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
                    totalCost += car.price;
                }
            }

            Console.WriteLine("Total Value of Stock: {0}",totalCost);
        }

        public static void ListCarDetails(List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (car.sold != true && car.mileage != 0 && car.yearsOld != 0)
                {
                    Console.WriteLine("Make: " + car.make + "\nModel: " + car.model + "\nPrice: " + car.price + "\nMileage: " + car.mileage + "\nThe car is {0} years old",car.yearsOld);
                }
                else
                {
                    //totalCars--;
                }

            }
        }


    }
}
