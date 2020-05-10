using LendCar.DBContext;
using LendCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LendCar.Repository
{
    public interface ICarRepository
    {
        LendCarDBContext Context { get; }
<<<<<<< HEAD
        Vehicle Find(string id);
        List<Img> GetImgForCurrntCar(string id);
=======
        Vehicle GetVehicle(int id);
        IQueryable<Vehicle> GetAllVehicles();
        void Add(Vehicle vehicle);
        void Delete(int id);
>>>>>>> 612fbfd0030ede5d44553c132b870d4bdf66f690
        void Save();
    }
}
