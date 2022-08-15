using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebBanHangOnline.Helpper;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly BanHangOnlineContext _context;
        public INotyfService _notifyService { get; }
        public NewsController(BanHangOnlineContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

        // GET: Admin/News
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lstNews = _context.News.AsNoTracking().Include(a => a.Cat).OrderByDescending(a => a.PostId);
            PagedList<News> models = new PagedList<News>(lstNews, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;

            return View(models);

        }
        // GET: Admin/News/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
               .Include(p => p.Cat)
               .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: Admin/News/Create
        public IActionResult Create()
        {
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName");
            return View();
        }

        // POST: Admin/News/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Tiltle,Scontents,Contents,Thumb,Published,Alias,CreteDate,Author,AccountId,Tags,CatId,IsHot,IsNewfedd,MetaKey,MetaDesc,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                news.Tiltle = Utilities.ToTitleCase(news.Tiltle);
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string Newname = Utilities.SEOUrl(news.Tiltle) + extension;
                    news.Thumb = await Utilities.UploadFile(fThumb, @"news", Newname.ToLower());

                }
                if (string.IsNullOrEmpty(news.Thumb)) news.Thumb = "default.jpg";
                news.Alias = Utilities.SEOUrl(news.Tiltle);
                news.CreteDate = DateTime.Now;
              


                _context.Add(news);
                await _context.SaveChangesAsync();
                _notifyService.Success("Tạo mới thành công");
                return RedirectToAction(nameof(Index));
            }
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName", news.CatId);
            return View(news);
        }

        // GET: Admin/News/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName", news.CatId);
                return NotFound();
            }
            return View(news);
        }

        // POST: Admin/News/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Tiltle,Scontents,Contents,Thumb,Published,Alias,CreteDate,Author,AccountId,Tags,CatId,IsHot,IsNewfedd,MetaKey,MetaDesc,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != news.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    {
                        news.Tiltle = Utilities.ToTitleCase(news.Tiltle);
                        if (fThumb != null)
                        {
                            string extension = Path.GetExtension(fThumb.FileName);
                            string Newname = Utilities.SEOUrl(news.Tiltle) + extension;
                            news.Thumb = await Utilities.UploadFile(fThumb, @"news", Newname.ToLower());

                        }
                        if (string.IsNullOrEmpty(news.Thumb)) news.Thumb = "default.jpg";
                        news.Alias = Utilities.SEOUrl(news.Tiltle);
                        news.CreteDate = DateTime.Now;



                        _context.Add(news);
                        await _context.SaveChangesAsync();
                        _notifyService.Success("Cập nhật thành công");
                        
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.PostId))
                    {
                        _notifyService.Success("Có lỗi xảy ra");

                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName", news.CatId);
            return View(news);
        }

        // GET: Admin/News/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
               .Include(p => p.Cat)
               .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: Admin/News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa thành công");
            return RedirectToAction(nameof(Index));

           
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.PostId == id);
        }
    }
}
