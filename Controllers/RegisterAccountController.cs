using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace BlindDating.Controllers
{
    public class RegisterAccountController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public RegisterAccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        // Show user the custom registration page.
        public IActionResult SignUp()
        {
            return View();
        }


        // Creates new user by posting information to database
        // and redirects to Creat A Profile Page.
        [HttpPost]
        public IActionResult CreateUser(string username, string password)
        {
            IdentityUser newUser = new IdentityUser();
            newUser.UserName = username;
            newUser.Email = username;

            IdentityResult result = _userManager.CreateAsync(newUser, password).Result;

            if (result.Succeeded)
            {
                // Add them to Normal User role.
                _userManager.AddToRoleAsync(newUser, "NormalUser").Wait();

               // Sign the user in with the new login.
                _signInManager.SignInAsync(newUser, false).Wait();
            }

            // Redirect to Create A Profile Page.
            return RedirectToAction("Create", "DatingProfiles");
        }
    }
}