using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();

            string WelcomeMessage = "Welcome to Cargo Ship. The goal of this game is to load the ship to its maximum capacity by adding motor cycles, cars, trucks and train cars. A cycle takes 3 units of weight. A car takes 5 units. A truck takes 11 units. A train car takes 17 units.";

            Console.WriteLine(WelcomeMessage);

            while (ship.Capacity !=ship.getShipLoad())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The ship capacity is " + ship.Capacity);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("The ship has " + ship.CycleCount + " motorcycles on board");
                Console.WriteLine("The ship has " + ship.CarCount + " cars on board");
                Console.WriteLine("The ship has " + ship.TruckCount + " trucks on board");
                Console.WriteLine("The ship has " + ship.TrainCarCount + " train cars on board");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("The ship currently has " + ship.getShipLoad() + " total units on board");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                int x;
                Console.WriteLine("How many motor cycles would you like to put on this ship ?");
                x = int.Parse(Console.ReadLine());
                ship.CycleCount = x;

                Console.WriteLine("How many cars would you like to put on this ship ?");
                x = int.Parse(Console.ReadLine());
                ship.CarCount = x;

                Console.WriteLine("How many trucks would you like to put on this ship ?");
                x = int.Parse(Console.ReadLine());
                ship.TruckCount = x;

                Console.WriteLine("How many train cars would you like to put on this ship ?");
                x = int.Parse(Console.ReadLine());
                ship.TrainCarCount = x;

                Console.WriteLine();
                Console.WriteLine("The ship now has " + ship.getShipLoad() + " total units of weight on board");
                Console.WriteLine();
                if (ship.overUnder() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The ship still has room to spare. Load more items.");
                }
                if (ship.overUnder() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ship still is overloaded. Take some items off!");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You loaded the ship successfully!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();
        }
    }
}
