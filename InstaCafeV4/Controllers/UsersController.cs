using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.AdminUsers;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InstaCafeV4.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Admin")]
    public class UsersController : Controller
    {
        private readonly CreateUsers _createUser;

        public UsersController(CreateUsers createUser)
        {
            _createUser = createUser;
        }

        public async Task<IActionResult> CreateUser(
            [FromBody] CreateUsers.Request request)
        {

            await _createUser.Do(request);
            /* managerUser = new IdentityUser()
            {
                UserName = vm.Username
            };

            //await _userManager.CreateAsync(managerUser, "password");

            //var managerClaim = new Claim("Role", "Manager");

            //await _userManager.AddClaimAsync(managerUser, managerClaim);*/

            return Ok();
        }
    }
}
