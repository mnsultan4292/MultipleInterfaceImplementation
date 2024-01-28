using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleInterfaceImplementation.Repository;
using System.Linq;
using System.Collections;
using MultipleInterfaceImplementation.Repository.Common;
//using Microsoft.AspNetCore.Mvc.HttpGet;

namespace MultipleInterfaceImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly ICommonFactoryRepo _repo;
        public CommonController(ICommonFactoryRepo commonRepo)
        {
            _repo = commonRepo;
        }

        [HttpGet]
        [Route("Amazon")]
        public IActionResult Amazon()
        {
            string str = string.Empty;
            var amazonInstance = _repo.GetInstance("Amazon");
            str = Convert.ToString(amazonInstance.GetCart());
            //var service = _shoppingCart.FirstOrDefault(x => x.GetType() == typeof(ShoppingCartAmazon));
            //if (service != null)
            //{
            //    str = Convert.ToString(service.GetCart());
            //}
            return Content(str);
        }
        //[HttpGet]
        //[Route("Flipkart")]
        //public IActionResult Flipkart()
        //{
        //    string str = string.Empty;
        //    var service = _shoppingCart.FirstOrDefault(x => x.GetType() == typeof(ShoppingCartFlipCart));
        //    if (service != null)
        //    {
        //        str = Convert.ToString(service.GetCart());
        //    }
        //    return Content(str);
        //}

        //[HttpGet]
        //[Route("Bay")]
        //public IActionResult Bay()
        //{
        //    string str = string.Empty;
        //    var service = _shoppingCart.FirstOrDefault(x => x.GetType() == typeof(ShoppingCartEBay));
        //    if (service != null)
        //    {
        //        str = Convert.ToString(service.GetCart());
        //    }
        //    return Content(str);
        //}
    }
}
