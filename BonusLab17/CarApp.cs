using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab17
{
    static class CarApp
    {
        
        public static void MakeCar()
        {
            List<Car> inventory = new List<Car>(GetCarList(HowMany()));
            Console.WriteLine("\nCurrent Inventory:");
            Console.WriteLine("============================");
            foreach (Car x in inventory)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public static int HowMany()
        {
            Console.WriteLine("\nHow many cars would you like to make?");
            if (int.TryParse(Console.ReadLine(), out int cars))
            {
                return cars;
            }
            else
            {
                Console.WriteLine("\nInvalid input.");
                return HowMany();
            }
        }
        
        public static List<Car> GetCarList(int cars)
        {
            List<Car> list = new List<Car>();
            for (int i = 0; i < cars; i++)
            {
                list.Add(BuildCar());
            }
            return list;
        }

        public static Car BuildCar()
        {
            try
            {
                Console.WriteLine("\nEnter Make");
                string make = (Console.ReadLine());
                Console.WriteLine("\nEnter Model");
                string model = (Console.ReadLine());
                Console.WriteLine("\nEnter Year");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter Price");
                double price = double.Parse(Console.ReadLine());
                Car newCar = new Car(make, model, year, price);

                return newCar;
            }
            catch
            {
                Console.WriteLine("\nOne or more inputs are invalid. Try again.");
                return BuildCar();
            }
        }
    }
}
