using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab17
{
    class Car
    {
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }
        protected double Price { get; set; }

        public Car()
        {
            Make = null;
            Model = null;
            Year = 0;
            Price = 0;
        }
        public Car(string make, string model, int year, double price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }
       
        public override string ToString()
        {
            return string.Format("{0, -9}{1, -16}{2, -9}" + string.Format("{0, -16:C2}", this.Price), this.Make, this.Model, this.Year);
        }

        //Methods used before learning get;set;
       
        //public void SetMake(string make)
        //{
        //    this.make = make;
        //}
        //public void SetModel(string model)
        //{
        //    this.model = model;
        //}
        //public void SetYear(int year)
        //{
        //    this.year = year;
        //}
        //public void SetPrice(double price)
        //{
        //    this.price = price;
        //}
        //public string GetMake()
        //{
        //    return this.make;
        //}
        //public string GetModel()
        //{
        //    return this.model;
        //}
        //public int GetYear()
        //{
        //    return this.year;
        //}
        //public double GetPrice()
        //{
        //    return this.price;
        //}
    }
}
