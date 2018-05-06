using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using BookCave.Services;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Book_Cave.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {

        private readonly UserManager<AspNetUsers> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<AspNetUsers> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        //Function that changes any claim
        public async Task ChangeClaim(string email, string newClaim)
        {
            await createRolesandUsers();
            /*
            var user = await _userManager.FindByEmailAsync(email);
            //var claim = (await _userManager.GetClaimsAsync(user))[0];
            var role  = (await _userManager.GetRolesAsync(user)).FirstOrDefault();

            if(role != null)
            {
                 await _userManager.RemoveFromRoleAsync(user, role);
            }
            await _userManager.AddToRoleAsync(user, newClaim);

            //await _userManager.RemoveClaimAsync(user, claim);
            //await _userManager.AddClaimAsync(user, new Claim(newClaim, $"{user.Name}"));
            */
        }


        //TODO: Find a better place for this
        [HttpPost]
        private async Task createRolesandUsers()
        {  
            AuthenticationService authenticationService = new AuthenticationService();

            bool x = await _roleManager.RoleExistsAsync("Admin");
            if (!x)
            {

                // first we create Admin role    
                var role = new IdentityRole();
                role.Name = "Admin";
                await _roleManager.CreateAsync(role);

                //Here we create a Admin super user who will maintain the website
                var model = new RegisterViewModel();
                model.Email = "default@default.com";
                model.Password = "Aa@12345";

                var user = authenticationService.InitializeAccount(model);

                IdentityResult chkUser = await _userManager.CreateAsync(user, model.Password);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = await _userManager.AddToRoleAsync(user, "Admin");
                }

                //Write user to db
            }

            // creating Creating Customer role     
            x = await _roleManager.RoleExistsAsync("Customer");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                await _roleManager.CreateAsync(role);

            }
        }

        //For adding roles to users
        public async Task AddRole(string email, string role)
        {
            //Find the requested user
            var user = await _userManager.FindByEmailAsync(email);

            bool roleCheck = await _userManager.IsInRoleAsync(user, role);
            if(!roleCheck)
            {
                await _userManager.AddToRoleAsync(user, role);
            }
        }

        //For removing roles from users
        public async Task RemoveRole(string email, string role)
        {
            //Find the requested user
            var user = await _userManager.FindByEmailAsync(email);

            bool roleCheck = await _userManager.IsInRoleAsync(user, role);
            if(roleCheck)
            {
                await _userManager.RemoveFromRoleAsync(user, role);
            }

        }
    }
}