using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleInterfaceImplementation.Repository;
using System.Linq;
//using Microsoft.AspNetCore.Mvc.HttpGet;

namespace MultipleInterfaceImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;
        //private readonly IShoppingCart _shoppingCart;
        public CartController( IServiceProvider serviceProvider)
        {
            //_shoppingCart = shoppingCart;
            _serviceProvider = serviceProvider;
        }

        [HttpGet]
        [Route("Inedx")]
        public IActionResult Index()
        {
            var services = _serviceProvider.GetService<IShoppingCart>();

            // Get required implementation from the collection
            //var pushNotificationReminder = services.FirstOrDefault(x => x.GetType() == typeof(PushNotificationReminderService));
            return Content("hello");
        }
    }
}
