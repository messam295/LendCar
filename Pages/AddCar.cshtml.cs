﻿using LendCar.Models;
using LendCar.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LendCar.Pages
{
    public class AddCarModel : PageModel
    {
        private IVehicleTypeRepository vehicleTypeRepo;
        private IBrandRepository brandRepo;
        private IBrandModelRepository brandModelRepo;
        private ICarRepository carRepo;
        private IWebHostEnvironment hostEnvironment;

        public AddCarModel(IVehicleTypeRepository vehicleTypeRepo,
                            ICarRepository carRepo,
                            IBrandRepository brandRepo,
                            IBrandModelRepository brandModelRepo,
                            IWebHostEnvironment hostEnvironment)
        {
            this.vehicleTypeRepo = vehicleTypeRepo;
            this.carRepo = carRepo;
            this.brandRepo = brandRepo;
            this.brandModelRepo = brandModelRepo;
            this.hostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public Vehicle Vehicle { get; set; }
        [BindProperty]
        public IEnumerable<IFormFile> VehiclePhotos { get; set; }
        public SelectList Brands { get; set; }
        public SelectList BrandModels { get; set; }
        public SelectList VehicleTypes { get; set; }
        public SelectList OdoMeters { get; set; }

        public void OnGet() 
        {
            this.VehicleTypes = new SelectList(vehicleTypeRepo.GetAllVehicleTypes().OrderBy(vt=>vt.Type), "Id", "Type");
            this.Brands = new SelectList(brandRepo.GetAllBrands().OrderBy(b=>b.Name), "Id", "Name");
            this.BrandModels = new SelectList(brandModelRepo.GetAllBrandModels().Where(bm=>bm.BrandId== brandRepo.GetAllBrands().OrderBy(b => b.Name).FirstOrDefault().Id).OrderBy(b=>b.Name), "Id", "Name");
            this.OdoMeters = new SelectList(carRepo.Context.OdoMeters.ToList(),"Id","Value");
        }
        public void OnPost(Vehicle Vehicle,IEnumerable<IFormFile> VehiclePhotos) 
        {
            
            if (!ModelState.IsValid)
            {
                RedirectToPage();
            }
            else
            {
                string newImgName = null;
                if (VehiclePhotos != null && VehiclePhotos.Count() > 0)
                {
                    List<Img> photos = new List<Img>();
                    foreach (var photo in VehiclePhotos)
                    {
                        string folder = Path.Combine(hostEnvironment.WebRootPath, "CarPhotosUploaded");
                        newImgName = $"{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_{photo.FileName}";
                        string file = Path.Combine(folder, newImgName);
                        FileStream fs = new FileStream(file, FileMode.Create);
                        photo.CopyTo(fs);
                        fs.Close();
                        photos.Add(new Img { Image = newImgName});
                        if (VehiclePhotos.ElementAt(0) == photo)
                        {
                            Vehicle.ImageUrl = newImgName;
                        }
                    }
                    Vehicle.Photos = photos;

                    carRepo.Add(Vehicle);
                    carRepo.Save();
                }
                RedirectToPage("/index");
            }
        }
    }
}
