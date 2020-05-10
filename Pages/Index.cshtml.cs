﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Web;
using LendCar.Models;
using LendCar.Repository;
using X.PagedList;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace LendCar.Pages
{
    //[BindProperties(SupportsGet = true)]
    [Authorize]
    public class IndexModel : PageModel
    {


        private readonly ILogger<IndexModel> _logger;
        public ICarRepository ICarRepository { get; }
        public IPagedList<Vehicle> Vehicles { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICarRepository ICarRepository)
        {
            _logger = logger;
            this.ICarRepository = ICarRepository;
        }

        public void OnGet()
        {
            Request.Query.TryGetValue("Page", out var page);
            int pageNumber;
            if (page.Count > 0)
            {
                if (int.TryParse(page[0], out var pageNum))
                {
                    pageNumber = pageNum;
                }
                else
                    pageNumber = 1;
            }
            else
                pageNumber = 1;


            //Vehicles = ICarRepository.GetAllVehicles().ToList().ToPagedList(pageNumber, 9);

            //Vehicles = ICarRepository.GetAllVehicles().Include(v=>v.Model).ThenInclude(v=>v.Brand).ToList().ToPagedList(pageNumber, 9);
        }

    }
}
