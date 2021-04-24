using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.AdminProducts;
using Shop.Application.AdminStocks;
using Shop.Database;
using System.Threading.Tasks;

namespace InstaCafeV4.Controllers
{

    [Route("[controller]")]
    [Authorize(Policy ="Mananger")]
    
    public class AdminController : Controller
    {






    }
}
