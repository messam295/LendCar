﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LendCar.DBContext;
using LendCar.Models;

namespace LendCar.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(LendCarDBContext Context)
        {
            this.Context = Context;
        }
        public LendCarDBContext Context { get; }
        public ApplicationUser Find(string id) => Context.People.SingleOrDefault(p => p.Id == id);

        public void Save() => Context.SaveChanges();

    }
}
