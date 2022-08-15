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
    public class BlogController : Controller
    {
        private readonly BanHangOnlineContext _context;

        public BlogController(BanHangOnlineContext context)
        {
            _context = context;
        }
        [Route("blogs.html", Name = "Blog")]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lstNews = _context.News.AsNoTracking().Include(a => a.Cat).OrderByDescending(a => a.PostId);
            PagedList<News> models = new PagedList<News>(lstNews, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;

            return View(models);

        }
        [Route("/tin-tuc/{Alias}-{id}.html", Name = "TinDetails")]
        public IActionResult Details(int id)
        {
            var news = _context.News.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (news == null)
            {
                return RedirectToAction("Index");

            }
            var lsbaivietlienquan = _context.News.
                AsNoTracking().Where(x => x.Published == true && x.PostId != id).
                Take(3).OrderByDescending(x => x.CreteDate).ToList();
            ViewBag.BaiVietLienQuan = lsbaivietlienquan;
            return View(news);
        }
    }
}
