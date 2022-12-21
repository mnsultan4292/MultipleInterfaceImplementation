using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleInterfaceImplementation.Repository;
using System.Linq;
using System.Collections;
//using Microsoft.AspNetCore.Mvc.HttpGet;

namespace MultipleInterfaceImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IEnumerable<IShoppingCart> _shoppingCart;
        public CartController( IEnumerable<IShoppingCart> shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        [HttpGet]
        [Route("Amazon")]
        public IActionResult Amazon()
        {
            string str = string.Empty;
            var service = _shoppingCart.FirstOrDefault(x => x.GetType() == typeof(ShoppingCartAmazon));
            if (service != null)
            {
                str = Convert.ToString(service.GetCart());
            }
            return Content(str);
        }
        [HttpGet]
        [Route("Flipkart")]
        public IActionResult Flipkart()
        {
            string str = string.Empty;
            var service = _shoppingCart.FirstOrDefault(x => x.GetType() == typeof(ShoppingCartFlipCart));
            if (service != null)
            {
                str = Convert.ToString(service.GetCart());
            }
            return Content(str);
        }

        [HttpGet]
        [Route("Bay")]
        public IActionResult Bay()
        {
            string str = string.Empty;
            var service = _shoppingCart.FirstOrDefault(x => x.GetType() == typeof(ShoppingCartEBay));
            if (service != null)
            {
                str = Convert.ToString(service.GetCart());
            }
            return Content(str);
        }
    }
}
