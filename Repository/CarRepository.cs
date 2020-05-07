﻿using LendCar.DBContext;
using LendCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LendCar.Repository
{
    public class CarRepository : ICarRepository
    {
        public CarRepository(LendCarDBContext Context)
        {
            this.Context = Context;
        }
        public LendCarDBContext Context { get; }
        public Vehicle Find(string id) => Context.Vehicles.SingleOrDefault(v => v.VIN == id);

        public List<Img> GetImgForCurrntCar(string id)
        {
            List<Img> imgs = Context.Imges.Where(i => i.Vehicle.VIN == id).ToList();
            return imgs;
        }

        public void Save() => Context.SaveChanges();
    }
}
