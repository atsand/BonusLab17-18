using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab17
{
    class UsedCar : Car
    {
        protected double Mileage { get; set; }

        public UsedCar()
        {
            this.Make = null;
            this.Model = null;
            this.Year = 0;
            this.Price = 0;
            
        }
        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price)
        {
            this.Mileage = mileage;
        }
        public override string ToString()
        {
            return string.Format("{0}{1, 6}{2, 5}", base.ToString(), Mileage, "(Used)");
        }
        
    }
}
