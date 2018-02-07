using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab17
{
    class Program
    {
        ////Run below for lab 17 or comment out to run lab 18
        //static void Main(string[] args)
        //{
        //    CarApp.MakeCar();
        //}
        ////Run above for lab 17 or comment out to run lab 18


        //Run below for lab 18 or comment out to run lab 17
        static void Main(string[] args)
        {
            GetChoice(CarList());
        }

        public static List<Car> CarList()
        {
            UsedCar used1 = new UsedCar("Jeep", "Cherokee", 1999, 201200, 5000);
            UsedCar used2 = new UsedCar("Honda", "Civic", 2012, 112200, 16000);
            UsedCar used3 = new UsedCar("Hummer", "Waste-o-Money", 2016, 45, 65000);
            Car car1 = new Car("Chevy", "Corvette", 2018, 55500);
            Car car2 = new Car("Nissan", "GTR", 2018, 99900);
            Car car3 = new Car("Audi", "R8", 2018, 165000);
            List<Car> carList = new List<Car>() { used1, used2, used3, car1, car2, car3 };
            return carList;
        }

        public static void PrintList(List<Car> list)
        {
            Console.WriteLine("\nHere is our inventory:");
            Console.WriteLine("=======================");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine((i+1) + ") " + list[i]);
            }
        }

        public static void GetChoice(List<Car> list)
        {
            string input;
            PrintList(list);
            Console.WriteLine("\nWhich car would you like? (Input a number or 'Q' to quit)");
            input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice<=list.Count && choice>0)
            {
                Console.WriteLine("\nYou've picked:\n===============");
                Console.WriteLine(list[choice-1]);
                if (BuyCar())
                {
                    list.Remove(list[choice-1]);
                }
                GetChoice(list);
            }
            else if (input.ToLower() == "q")
            {
                return;
            }
            else
            {
                Console.WriteLine("\nInvalid input.");
                GetChoice(list);
            }
        }

        public static bool BuyCar()
        {
            string input;
            Console.WriteLine("\nWould you like to buy this car? (Y/N)");
            input = Console.ReadLine();
            if (input.ToLower()=="y")
            {
                return true;
            }
            else if (input.ToLower()=="n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return BuyCar();
            }
        }
        //Run above for lab 18 or comment out to run lab 17
    }
}
