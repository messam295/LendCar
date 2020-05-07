using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//HEAD
//c07c1805e91b39914557ab570427b249dd777b46
using System.Linq;
using System.Threading.Tasks;

namespace LendCar.Models
{
    public class Img
    {
        public int Id { get; set; }
      
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
