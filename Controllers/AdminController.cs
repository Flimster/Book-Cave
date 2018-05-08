using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using BookCave.Services;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BookCave.Models.RegistrationModels;
using BookCave.Data;
using System.Collections.Generic;

namespace BookCave.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly DataContext _db;
        private readonly UserManager<AspNetUsers> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private BookService _bs = new BookService();
        private readonly AdminService _adminService;

        public AdminController(UserManager<AspNetUsers> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = new DataContext();
            _adminService = new AdminService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetManageBooks()
        {
            return Json(BookCave.FakeDatabase.Books);
        }

        [HttpGet]
        public JsonResult getUsers()
        {
            var user1 = new UserPrivateViewModel()
            {
                Id = 1,
                Image = "https://mk0slamonlinensgt39k.kinstacdn.com/wp-content/uploads/2017/04/lebron_james_travel.jpg",
                Email = "someemail@gmail.com",
                Name = "Lebron James"
            };
             var user2 = new UserPrivateViewModel()
            {
                Id = 1,
                Image = "https://mk0slamonlinensgt39k.kinstacdn.com/wp-content/uploads/2017/04/lebron_james_travel.jpg",
                Email = "someemail@gmail.com",
                Name = "Lebron James"
            };

            var users = new List<UserPrivateViewModel>(){user1, user2};
            return Json(users);
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

            bool check = await _roleManager.RoleExistsAsync("Admin");
            if (!check)
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
            check = await _roleManager.RoleExistsAsync("Customer");
            if (!check)
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

            //Doing this instead of the above makes _userManager = null
            //await _authenticationService.AddRole(email, role);
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

            //Doing this instead of the above makes _userManager = null
            //await _authenticationService.Remove(email, role);
        }

        [HttpPost]
        public IActionResult CreateBook(BookRegistrationModel book)
        {
            if(!ModelState.IsValid)
            {
                //TODO implement error printout
                ViewData["ErrorMessage"] = "Error";
                return View("Error", "Home");
            }

            _adminService.ProcessNewBook(book);

            _bs.WriteBook(book);
            return View("Index");
        }

        [HttpGet]
        public List<BookViewModel> GetBookList()
        {
            var books = _bs.GetList();
            return books;
        }

    }
}