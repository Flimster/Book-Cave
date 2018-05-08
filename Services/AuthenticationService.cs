using System;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookCave.Services
{
    public class AuthenticationService
    {
        AspNetUsers _user;
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthenticationService(UserManager<AspNetUsers> userManager, RoleManager<IdentityRole> roleManager)
        {
            _user = new AspNetUsers();
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public AuthenticationService()
        {
            _user = new AspNetUsers();
        }

        public AspNetUsers InitializeAccount(RegisterViewModel model)
        {
            _user = new AspNetUsers
            {
                Image = "~/Images/DefaultProfileImage.png",
                FavoriteBookId = 1,
                FavoriteAuthorId = 1,
                RegistrationDate = DateTime.Now,
                LastLoggedInDate = DateTime.Now,
                BookSuggestionsEmail = false,
                ActiveStatus = true,
                TotalReports = 0,
                TotalBans = 0,
                UserName = model.Email,
                Email = model.Email,
                Name = model.Name,
            };

            return _user;
        }


        //_userManager and _roleManager always null when passing managers
        //Add default role to account
        public async Task<bool> AddRole(string email, string role)
        {
            //Find the requested user
            var user = await _userManager.FindByEmailAsync(email);

            //Check if user has the requested role
            bool roleCheck = await this._roleManager.RoleExistsAsync(role);
            if(!roleCheck)
            {
                await _userManager.AddToRoleAsync(user, role);
                return true;
            }
            return false;
        }

        //Remove a role from an account
        public async Task<bool> RemoveRole(string email, string role)
        {
            //Find the requested user
            var user = await _userManager.FindByEmailAsync(email);
            
            //Check if user has the requested role
            bool roleCheck = await _userManager.IsInRoleAsync(user, role);
            if(roleCheck)
            {
                await _userManager.RemoveFromRoleAsync(user, role);
                return true;
            }
            return false;
        }
        
    }
}