﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LendCar.Models;
using LendCar.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LendCar.Controllers
{
    [Route("Photo")]
    public class PhotoController : Controller
    {
        public PhotoController(IWebHostEnvironment hostEnvironment,IUserRepository userRepostiory)
        {
            HostEnvironment = hostEnvironment;
            UserRepostiory = userRepostiory;
        }
        public IWebHostEnvironment HostEnvironment { get; }
        public IUserRepository UserRepostiory { get; }

        [Route("Upload")]
        public IActionResult Upload(string userId, IFormFile photo)
        {
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {
                ApplicationUser user = UserRepostiory.FindById(userId);
                string oldImg = user.ImageUrl;
                System.IO.File.Delete(Path.Combine(HostEnvironment.WebRootPath,oldImg.Replace("~/","")));
                string photoName = Guid.NewGuid().ToString() + DateTime.Now.ToString("dd-MM-yyyy") + Path.GetExtension(photo.FileName);
                string physicalPath = Path.Combine(HostEnvironment.WebRootPath, "images", "users" , photoName);
                string relativePath = $"~/images/users/{photoName}";
                using (var file = new FileStream(physicalPath, FileMode.Create))
                {
                    photo.CopyTo(file);
                }
                UserRepostiory.EditPhotoPath(userId,relativePath );
                UserRepostiory.Save();
                //var image = System.IO.File.OpenRead(physicalPath);
                return Json(true);
            }
            return NotFound();
        }
    }
}