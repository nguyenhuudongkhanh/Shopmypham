using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{

    public class ProductsController : Controller
    {
        private readonly BanHangOnlineContext _context;
        public INotyfService _notifyService { get; }
        public ProductsController(BanHangOnlineContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }
        [Route("shoponline.html", Name = "ShopProduct")]
        public IActionResult Index(int page=1, int CatID = 0)
        {
            var pageNumber = page;
            var pageSize = 20;
            List<Product> lstProduct = new List<Product>();

            if (CatID != 0)
            {
                lstProduct = _context.Products
                    .AsNoTracking()
                    .Where(a => a.CatId == CatID)
                    .Include(a => a.Cat)
                    .OrderByDescending(a => a.ProductsId).ToList();
            }
            else
            {
                lstProduct = _context.Products.
                AsNoTracking()
                .Include(a => a.Cat)
                .OrderByDescending(a => a.ProductsId).ToList();


            }
            PagedList<Product> models = new PagedList<Product>(lstProduct.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentCateID = CatID;
            ViewBag.CurrentPage = pageNumber;
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName", CatID);
            return View(models);
            //try
            //{
            //    var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            //    var pageSize = 20;
            //    var lstProduct = _context.Products.AsNoTracking().Include(a => a.Cat).OrderByDescending(a => a.DateCreated);
            //    PagedList<Product> models = new PagedList<Product>(lstProduct, pageNumber, pageSize);
            //    ViewBag.CurrentPage = pageNumber;
            //    return View(models);
            //}
            //catch
            //{
            //    return RedirectToAction("Index", "Home");
            //}

        }
        public IActionResult Filtter(/*int? page*/ int CatID = 0/* int Active = 0*/)
        {
            //var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var url = $"/Products?CatID={CatID}";
            if (CatID == 0)
            {
                url = $"/Products/Index";

            }
            //else
            //{

            //    if (Active == 0) url = $"/Admin/Products?CatID={CatID}";
            //    if (CatID == 0) url = $"/Admin/Products?Active={Active}";
            //}

            return Json(new { status = "succsess", redirectUrl = url });

        }
        [Route("/{Alias}", Name = "ListProduct")]
        public IActionResult List(string Alias, int page = 1)
        {
            try
            {
                var pageSize = 20;
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x=>x.Alias==Alias);
                var lstProduct = _context.Products.AsNoTracking().Where(x => x.CatId == danhmuc.CatId)
                    .Include(a => a.Cat).OrderByDescending(a => a.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lstProduct, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch { return RedirectToAction("Index", "Home"); }


        }
        [Route("/{Alias}-{id}.html", Name = "productsDetails")]
        public IActionResult Details(int id)
        { 
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductsId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsproduct = _context.Products.AsNoTracking().
                    Where(x => x.CatId == product.CatId && x.ProductsId != id && x.Active == true).OrderByDescending(x=>x.DateCreated).
                  ToList();
                ViewBag.SanPham = lsproduct;
              
                return View(product);
            }
            catch { return RedirectToAction("Index", "Home"); }

        }
    }
}
