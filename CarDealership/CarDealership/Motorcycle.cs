using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Motorcycle : Vehicle
    {
        private string type;
        private int weight;
        private int maxSpeed;

        public static int totalMotorbikes;





        public Motorcycle(string make, string model, int price, int weight, int maxSpeed) : base(make, model, price)
        {

            this.type = "Motorcycle";
            //this.make = make;
            //this.model = model;
            //this.price = price;
            this.weight = weight;
            this.maxSpeed = maxSpeed;
            this.sold = false;
            totalMotorbikes++;

        }

        public Motorcycle(string make, string model, int price, int weight, int maxSpeed, int mileage, int yearsOld) : base(make, model, price, mileage, yearsOld)
        {
            this.type = "Motorcycle";
            //this.make = make;
            //this.model = model;
            //this.price = price;
            this.weight = weight;
            this.maxSpeed = maxSpeed;
            this.sold = false;
            this.mileage = mileage;
            this.yearsOld = yearsOld;
            totalMotorbikes++;

        }

        public new void Display()
        {


            Console.WriteLine("Make: " + Make + "\nModel: " + Model + "\nPrice: " + Price + "\nWeight" + weight);
        }

        public void SellBike(bool sold, int price)
        {
            this.sold = sold;
            this.Price = price;
        }

        public static void ListSoldBikes(List<Motorcycle> motorcycles)
        {
            


            foreach (var bike in motorcycles)
            {

                if (bike.sold == true)
                {


                    Console.WriteLine("Make: " + bike.Make + "\nModel: " + bike.Model + "\nPrice: " + bike.Price + "\nWeight: " + bike.weight + "Kg\nMax Speed: " + bike.maxSpeed + "MPH");
                    Console.WriteLine("----------------------");
                }
                
            }

        }

        public static void ListBikes(List<Motorcycle> motorcycles)
        {
            int totalMotorbike = totalMotorbikes;
            

            foreach (var bike in motorcycles)
            {

                if (bike.sold != true)
                {
                    

                    Console.WriteLine("Make: " + bike.Make + "\nModel: " + bike.Model + "\nPrice: " + bike.Price + "\nWeight: " + bike.weight + "Kg\nMax Speed: " + bike.maxSpeed + "MPH");
                    Console.WriteLine("----------------------");
                }
                else
                {
                    totalMotorbike--;
                }

                totalMotorbikes = totalMotorbike;
            }

        }

        public static void ValueInStock(List<Motorcycle> motorcycles)
        {
            int totalCost = 0;

            foreach (var bike in motorcycles)
            {
                if (bike.sold != true)
                {
                    totalCost += bike.Price;
                }
            }

            Console.WriteLine("Total Value of Stock of motorcycles: {0}", totalCost);
        }

        public static void ListMotorCycleDetails(List<Motorcycle> motorcycles)
        {
            foreach (var bike in motorcycles)
            {
                if (bike.sold != true && bike.mileage != 0 && bike.yearsOld != 0)
                {
                    Console.WriteLine("Make: " + bike.Make + "\nModel: " + bike.Model + "\nPrice: " + bike.Price + "\nWeight: " + bike.weight + "Kg\nMax Speed: " + bike.maxSpeed + "MPH\nMileage: " + bike.mileage + "\nThe car is {0} years old", bike.yearsOld);
                }


            }
        }


    }
}
