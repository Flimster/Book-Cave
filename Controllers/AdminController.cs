using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Book_Cave.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController
    {

        private readonly UserManager<AspNetUsers> _userManager;

        public AdminController(UserManager<AspNetUsers> userManager)
        {
            _userManager = userManager;
        }
        
        //Function that changes any claim
        public async Task ChangeClaim(string email, string newClaim)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var claim = (await _userManager.GetClaimsAsync(user))[0];
            
            await _userManager.RemoveClaimAsync(user, claim);
            await _userManager.AddClaimAsync(user, new Claim(newClaim, $"{user.Name}"));
            
        }
    }
}