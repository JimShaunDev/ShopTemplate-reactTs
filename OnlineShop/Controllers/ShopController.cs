using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        public List<string> GetItems()
        {
            return new List<string>() { "vrwbwrbb", "bsfwqfwf", "ffeqfefe", "rfeqfg", "efefggegewg", "regregrg" };
        }

    }
}
