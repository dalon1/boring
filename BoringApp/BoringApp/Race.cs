using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoringApp.Interface;
using BoringApp.Model;
using BoringApp.Static;
using System.Threading;
using System.Diagnostics;

namespace BoringApp
{
    class Race : IRace
    {
        private string TotalTime { get; set; }
        public void StartRace(params Car[] cars)
        {
            int distance;
            bool status;
            do
            {
                Console.Write("Enter distance (meters): ");
                string d = Console.ReadLine();
                status = int.TryParse(d, out distance);
                if (status)
                    distance = int.Parse(d);
            } while (!status || distance == 0);

            // Starting timer here >>
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string s = String.Format("{0} ", "TIME".PadRight(10));
            int i = 0;
            foreach (Car car in cars)
                s += String.Format("{0} {1} | {2} ", car.Brand.PadLeft(10), "SPEED".PadRight(10), "DISTANCE".PadRight(5));

            Console.WriteLine(s);
            s = "";

            Random rand = new Random();
            while(!this.IsOver(distance, cars))
            {
                i++;
                s = String.Format("{0, 7}{1:3}", (i + 1) * 10000, Time.Format.SEC.ToString().ToLower());
                foreach (Car car in cars)
                {
                    car.Acceleration = rand.Next(-20, 21);
                    if (car.Speed + car.Acceleration > 0)
                    {
                        car.Speed += car.Acceleration;
                        car.DistanceTravelled += car.SetDistanceTravelled(car.Speed);
                    } else
                    {
                        car.Speed = 0;
                        car.DistanceTravelled +=  car.SetDistanceTravelled(car.Speed);
                    }
                    
                    s += String.Format("{0} {1} {2} | {3}M", "".PadRight(10), car.Speed.ToString().PadRight(5),
                        Speed.KMxHR().Value, car.DistanceTravelled.ToString().PadRight(4)); // change this
                }
                Thread.Sleep(500);
                Console.WriteLine(s);
                s = "";
            }

            // Ending timer here >>
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);          
        }

        public void PrepareRace(params Car[] cars)
        {

            Console.WriteLine(RaceTitle.PrintHeader());
            Console.WriteLine(RaceTitle.PrintCarTable(cars));

            string s = "";

            while (s.Length < 100)
            {
                Thread.Sleep(new Random().Next(1, 5) * 1000);
                int limit = new Random().Next(1, 15);
                for (int i = 0; i < limit; i++)
                {
                    if (s.Length + i <= 100)
                    {
                        Console.Write("#");
                    }
                    s += "#";
                }
            }
            Console.Write(" >> 100% - READY!");
            Console.WriteLine("\n");
        }

        public void EndRace()
        {
            throw new NotImplementedException();
        }

        public bool IsOver(int distance, params Car[] cars)
        {
            foreach (Car car in cars)
                if (car.DistanceTravelled >= distance)
                    return true;
            return false;
        }

        
    }
}
