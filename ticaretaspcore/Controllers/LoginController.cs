using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ticaretaspcore.Models;
namespace ticaretaspcore.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> login_in(Admin gelen)
        {
            var sorgu = _context.Admins.Where(x => x.users == gelen.users && x.pass == gelen.pass).FirstOrDefault();
            if(sorgu!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,gelen.users)
                };
                var useridentity=new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Main");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return View();
        }
        public IActionResult Yetkisiz()
        {
            return View();
        }
        public IActionResult Main()
        {
            return View();
        }
    }
}
