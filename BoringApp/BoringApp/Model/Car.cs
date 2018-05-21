using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoringApp.Model
{
    public class Car
    {
        public String Brand { get; set; }
        public String Model { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; }
        public int Acceleration { get; set; }
        public double DistanceTravelled { get; set; }

        public Car(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
            this.Speed = 0;
            this.MaxSpeed = 0;
            this.Acceleration = 0;
            this.DistanceTravelled = 0;
        }

        public double SetDistanceTravelled(int speed)
        {
            if (speed < 0)
                return 0;

            return (speed * 1_000) / 3_600;
        }

        public override string ToString()
        {
            return String.Format("Brand: {0}, Model: {1}, Max Speed: {2}", this.Brand, this.Model, this.MaxSpeed);
        }
    }
}
