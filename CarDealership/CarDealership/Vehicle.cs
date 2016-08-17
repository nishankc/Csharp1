using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Vehicle { 
        public string make;
        public string model;
        public int price;
        public bool sold;
        public int mileage;
        public int yearsOld;

        





        public Vehicle(string make, string model, int price)
        {
    
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
        

        }

        public Vehicle(string make, string model, int price, int mileage, int yearsOld)
        {

            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.mileage = mileage;
            this.yearsOld = yearsOld;
        

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

        public virtual void Display()
        {


            Console.WriteLine("Make: " + Make + "\nModel: " + Model + "\nPrice: " + Price);
        }



    }
}
