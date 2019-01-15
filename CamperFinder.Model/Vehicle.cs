using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamperFinder.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Vehicle(int id, string make, string model, string name, string shortDesc, int mileage, int year, decimal price)
        {
            Id = id;
            Make = make;
            Model = model;
            Name = name;
            ShortDesc = shortDesc;
            Mileage = mileage;
            Year = year;
            Price = price;
        }
    }
}
