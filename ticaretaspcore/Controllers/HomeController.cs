using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ticaretaspcore.Models;
namespace ticaretaspcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var sorgu = _context.Products.ToListAsync();
            ViewBag.urunler = sorgu;
            return View();
        }
        public async Task<IActionResult> getProuct(int? id)
        {
            var sorgu = await _context.Products.Where(x => x.product_Id == id).FirstOrDefaultAsync();
            return View(sorgu);
        }
        public async Task<IActionResult> PartialOurProduct()
        {
            var sorgu =await _context.Products.ToListAsync();
            return PartialView("_PartialOurProduct", sorgu);
        }
        [HttpPost]
        public async Task<IActionResult> Details(string arama)
        {
            var sorgu = await _context.Products.Where(x => x.product_Name.Contains(arama)).ToListAsync();
            return View(sorgu);
        }

        public async Task<IActionResult> artir()
        {
            var sorgu= await _context.Products.OrderBy(x => x.product_Name).ToListAsync();
            return PartialView("_PartialOurProduct", sorgu);
        }

        public async Task<IActionResult> azalt()
        {
            var sorgu = await _context.Products.OrderByDescending(x => x.product_Name).ToListAsync();
            return PartialView("_PartialOurProduct", sorgu);
        }
    }
}
