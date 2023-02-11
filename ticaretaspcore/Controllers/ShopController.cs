using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticaretaspcore.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Checkout()
        {
            var CardProductsCookie = Request.Cookies["CardProducts"];
            if(CardProductsCookie!=null)
            {
                var productIDs = CardProductsCookie.ToString();
            }

            return View();
        }
    }
}
