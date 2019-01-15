﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CamperFinder.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CamperFinder.Api.Controllers
{
    [Route("api/vehicles")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        List<Vehicle> _vehicles;
        
        public VehiclesController()
        {
            _vehicles = new List<Vehicle>()
            {
                new Vehicle(1, "VW", "California", "Maggie", "Beige, 180PS DSG", 43500, 2012, 37000),
                new Vehicle(2, "VW", "California", "Daisy", "Green, 150PS Manual", 80000, 2009, 28000),
                new Vehicle(3, "VW", "California", "Gerald", "Red/White", 500, 2018, 52000),
                new Vehicle(4, "Fiat", "IH Premier", "Dixie", "Blue", 3500, 2017, 75000),
                new Vehicle(5, "Mercedes", "Vito", "Muffin", "Silver", 79568, 2008, 12000),
                new Vehicle(6, "Mercedes", "Vito", "Florry", "Gold", 21000, 2008, 65400),
                new Vehicle(7, "VW", "Transporter", "Brian", "Blue", 123000, 2005, 187000),
            };
        }

        // GET: api/vehicles
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _vehicles;
        }

        // GET: api/vehicles/5
        [HttpGet("{id:int}")]
        public Vehicle Get(int id)
        {
            return _vehicles.FirstOrDefault(v => v.Id == id);
        }

        // GET: api/vehicles/vw
        [HttpGet("{make}")]
        public IEnumerable<Vehicle> Get(string make)
        {
            return _vehicles.Where(v => v.Make.Equals(make, StringComparison.InvariantCultureIgnoreCase));
        }

        // POST: api/vehicles
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Vehicle/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
