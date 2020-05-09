using LendCar.DBContext;
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
<<<<<<< HEAD
        public Vehicle Find(string id) => Context.Vehicles.SingleOrDefault(v => v.VIN == id);

        public List<Img> GetImgForCurrntCar(string id)
        {
            List<Img> imgs = Context.Imges.Where(i => i.Vehicle.VIN == id).ToList();
            return imgs;
        }

=======
        public Vehicle GetVehicle(int id) => Context.Vehicles.SingleOrDefault(c => c.Id == id);
        public List<Vehicle> GetAllVehicles() => Context.Vehicles.ToList();
        public void Add(Vehicle vehicle) => Context.Vehicles.Add(vehicle);
        public void Delete(int id) => Context.Vehicles.Remove(GetVehicle(id));
>>>>>>> 612fbfd0030ede5d44553c132b870d4bdf66f690
        public void Save() => Context.SaveChanges();
    }
}
