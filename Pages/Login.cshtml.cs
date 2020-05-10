using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LendCar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LendCar.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public SignInManager<ApplicationUser> SignInManager { get; }
        public UserManager<ApplicationUser> Usermanger { get; }

        public LoginModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> usermanger)
        {
            SignInManager = signInManager;
            Usermanger = usermanger;
        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            //await Usermanger.CreateAsync(new ApplicationUser()
            //{
            //    Email = "mohamedesam9397@gmail.com",
            //    UserName = "MohamedEsam",
            //    Image = "https://lh3.googleusercontent.com/-xkin9yi5v5E/AAAAAAAAAAI/AAAAAAAAAAA/AMZuucnOElStaOw_H_2SsTTYEoZyntSIyQ/photo.jpg?sz=46",
            //    NationalId = "12345678998752",
            //    FirstName = "Mohamed",
            //    Gender = new Gender() { Type = "Male" },
            //    Country = "Egypt",
            //    TripsNumber = 2334,
            //    City = "Minya",
            //    LastName = "Esam",
            //}, "Sara@ask123.com"); 

            Email = "MohamedEsam";
            Password = "Sara@123.com";

            var result = await SignInManager.PasswordSignInAsync(Email, Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToPage("./adminDashboard");
            }
            return RedirectToPage("./Login");
        }
    }
}