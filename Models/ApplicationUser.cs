using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LendCar.Models
{
    public class ApplicationUser : IdentityUser
    {
       
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        [DataType(DataType.ImageUrl)]
        // HEAD
        public string Image { get; set; }

        public string DriverLicenseNumber { get; set; }

       //c07c1805e91b39914557ab570427b249dd777b46
        [DataType(DataType.MultilineText)]
        public string BriefAboutMe { get; set; }

        public int TripsNumber { get; set; }


        public int GenderId { get; set; }
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
        
        public virtual ICollection<Vehicle> VehiclesOwnedByHim { get; set; }

        [InverseProperty("Renter")]
        public virtual ICollection<Vehicle> VehiclesRentalByHim { get; set; }

//HEAD
        // public ICollection<Vehicle> Vehicles { get; set; }


    }
}
