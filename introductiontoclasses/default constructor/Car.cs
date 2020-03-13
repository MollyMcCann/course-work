using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_constructor
{
    public class Car
    {
        //private fields
        private string make;
        private string model;
        private int year;
        private int mileage;
        private decimal price;

        //custom constructor
        public Car(string make, string model, int year, int mileage,decimal price)
        {
            this.make = make;
            this.model= model;
            this.year = year;
            this.mileage = mileage;
            this.price = price;

        }   
        //default constructor: is constructor with NO parameters
        public Car()
        {
            this.make = " Honda";
            this.model = "Carolla";
            this.year = 2000;
            this.mileage = 21000;
            this.price =3000;
        }
        //accessors:getters
        public string GetMake()
        {
            return this.make;
        }
        //as a property:should always start with a capital letter. Its purpose is to provide 
        //controlled access to a private field
        //you can use the get by itself or use Both get and set
        public string Make
        {
            get
            {
                return this.make;
            }
        }
        public string GetModel()
        {
            return this.model;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
        }
       public int Year { get { return this.year; } }
        public int Mileage { get { return this.mileage; } }
        public decimal Price { get { return this.mileage; } }
        

    }
}
