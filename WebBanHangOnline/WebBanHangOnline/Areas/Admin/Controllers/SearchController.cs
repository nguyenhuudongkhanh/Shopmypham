using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {

        private readonly BanHangOnlineContext _context;
        public SearchController(BanHangOnlineContext context)
        {
            _context = context;

        }

        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if(string.IsNullOrEmpty(keyword)|| keyword.Length<1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.Products.AsNoTracking().Include(a => a.Cat).Where(x => x.ProductsName.Contains(keyword))
                .OrderByDescending(x => x.ProductsName).Take(10).ToList();
            if(ls==null)
            {

                return PartialView("ListProductsSearchPartial", null);

            }   
            else
            {
                return PartialView("ListProductsSearchPartial", ls);


            }
        }
    }
}
