using Microsoft.AspNetCore.Authorization;

namespace Book_Cave.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController
    {
        
    }
}