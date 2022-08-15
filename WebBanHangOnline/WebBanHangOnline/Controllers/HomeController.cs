using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;
using WebBanHangOnline.ModelView;

namespace WebBanHangOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly BanHangOnlineContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,BanHangOnlineContext context)
        { 
          
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            try
            {
                HomeVN model = new HomeVN();
                var lsProducts = _context.Products.AsNoTracking().Where(x => x.Active == true && x.HomeFlag == true)
                   .OrderByDescending(x => x.DateCreated).ToList();


                List<ProductHomeVN> lsproductViews = new List<ProductHomeVN>();
                var lsCat = _context.Categories.AsNoTracking().
                    Where(x => x.Published == true)
                   .OrderByDescending(x => x.Ordering).ToList();
                foreach (var item in lsCat)
                {
                    ProductHomeVN producthomevn = new ProductHomeVN();
                    producthomevn.Category = item;
                    producthomevn.lsProduct = lsProducts.Where(x => x.CatId == item.CatId).ToList();
                    lsproductViews.Add(producthomevn);
                }
                var News = _context.News.AsNoTracking().
                    Where(x => x.Published == true && x.IsNewfedd == true)
                    .OrderByDescending(x => x.CreteDate).Take(3).ToList();
                model.Products = lsproductViews;
                model.News = News;
                ViewBag.ALLProduct = lsProducts;


                return View(model);

            }
            catch (Exception ex)
            {
                return View();
            }

        }
        [Route("gioi-thieu.html", Name = "About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("lien-he.html", Name = "Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
