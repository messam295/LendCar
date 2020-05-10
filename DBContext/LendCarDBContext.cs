﻿using LendCar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LendCar.DBContext
{
    public class LendCarDBContext : IdentityDbContext<ApplicationUser>
    {
        public LendCarDBContext(DbContextOptions<LendCarDBContext> options) : base(options)  { }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<OdoMeter> OdoMeters { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
<<<<<<< HEAD
        public DbSet<Img> Imges { get; set; }
=======
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandModel> BrandModels { get; set; }
>>>>>>> 612fbfd0030ede5d44553c132b870d4bdf66f690

    }
}
