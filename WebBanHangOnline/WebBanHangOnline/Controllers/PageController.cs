using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class PageController : Controller
    {
        private readonly BanHangOnlineContext _context;

        public PageController(BanHangOnlineContext context)
        {
            _context = context;
        }

        [Route("/page/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            if (string.IsNullOrEmpty(Alias)) return RedirectToAction("Index", "Home");
            var pages = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (pages == null)
            {
                return RedirectToAction("Index", "Home");

            }
          
            return View(pages);
        }
    }
}
