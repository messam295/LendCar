using System;
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
<<<<<<< HEAD
        public ApplicationUser Find(string id) => Context.People.SingleOrDefault(p => p.Id == id);

=======
        public ApplicationUser Find(string id) => Context.Users.SingleOrDefault(p => p.NationalId == id);
>>>>>>> dbde1e69832044cba229375719faa01703521524
        public void Save() => Context.SaveChanges();

    }
}
