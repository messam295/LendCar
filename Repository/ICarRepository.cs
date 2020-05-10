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
        Vehicle Find(string id);
        List<Img> GetImgForCurrntCar(string id);
        Vehicle GetVehicle(int id);
        IQueryable<Vehicle> GetAllVehicles();
        void Add(Vehicle vehicle);
        void Delete(int id);
        void Save();
    }
}
