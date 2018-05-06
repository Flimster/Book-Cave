using System.Security.Claims;
using System.Threading.Tasks;
using BookCave.Models;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BookCave.Services;

namespace BookCave.Data.EntityModels
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AspNetUsers> _signInManager;
        private readonly UserManager<AspNetUsers> _userManager;

        public AccountController(SignInManager<AspNetUsers> signInManager, UserManager<AspNetUsers> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            AuthenticationService authenticationService = new AuthenticationService();
            //await authenticationService.createRolesandUsers();

            if(!ModelState.IsValid)
            {
                return View();
            }

            var user = authenticationService.InitializeAccount(model);
            var result = await _userManager.CreateAsync(user, model.Password);

            if(result.Succeeded)
            {
                //User successfully registered
                await _userManager.AddClaimAsync(user, new Claim("Customer", $"{model.Name}"));
                await authenticationService.AddRole(user, "Customer");
                await _signInManager.SignInAsync(user, false);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]


        public async Task<ActionResult> ResetPassword(ForgotPasswordViewModel model)   //TODO: Connect db and test
        {

            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);
                if(user == null)
                {
                    return View("Index", "Home");
                }
                /* 
                string code = await _userManager.GeneratePasswordResetTokenAsync(user.Id);
                var callbackUrl = Url.Action("ResetPassword", "Account", new {userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                await _userManager.SendEmailAsync(user.Id, "ResetPassword", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                */
            }
            return View("Index", "Home");
        }
        
    }
}