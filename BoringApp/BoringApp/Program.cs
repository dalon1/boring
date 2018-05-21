using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoringApp.Model;

namespace BoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[] {
                    new Car("Dannel", ""),
                new Car("Joel", ""),
                new Car("Eitan", "") };

            Race race = new Race();
            race.PrepareRace(cars);
            race.StartRace(cars);
            Console.ReadKey();
        }
    }
}
