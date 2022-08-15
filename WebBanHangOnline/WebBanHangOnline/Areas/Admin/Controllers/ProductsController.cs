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
    public class ProductsController : Controller
    {
        private readonly BanHangOnlineContext _context;
        public INotyfService _notifyService { get; }
        public ProductsController(BanHangOnlineContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

       
        // GET: Admin/Products
        public IActionResult Index(int page=1,int CatID=0)
        {
            var pageNumber = page ;
            var pageSize = 20;
            List<Product> lstProduct = new List<Product>();
            
            if(CatID !=0)
            {
                lstProduct = _context.Products
                    .AsNoTracking() 
                    .Where(a=>a.CatId==CatID) // điều kiện là gì
                    .Include(a => a.Cat)// thuộc loại danh mục nào
                    .OrderByDescending(a => a.ProductsId).ToList();//sắp xép giảm dần
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
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName",CatID);
            return View(models);

        }
        public IActionResult Filtter(/*int? page*/ int CatID = 0/* int Active = 0*/)
        {
            //var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var url = $"/Admin/Products?CatID={CatID}";
            if(CatID==0 )
            {
                url = $"/Admin/Products";

            }    
            //else
            //{

            //    if (Active == 0) url = $"/Admin/Products?CatID={CatID}";
            //    if (CatID == 0) url = $"/Admin/Products?Active={Active}";
            //}

            return Json(new { status = "succsess", redirectUrl = url });

        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductsId == id);//  sử dụng phương thức mở rộng không đồng bộ FirstOrDefaultAsync để trả về kết quả.
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductsId,ProductsName,ShortDesc,Description,CatId,Price,Discount,Thumb,Video,DateCreated,DateModifiled,BestSellers,HomeFlag,Active,Tags,Tiltle,Alias,MetaDesc,MetaKey,UnitslnStock")] Product product, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                product.ProductsName = Utilities.ToTitleCase(product.ProductsName);
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string Newname = Utilities.SEOUrl(product.ProductsName) + extension;
                    product.Thumb = await Utilities.UploadFile(fThumb, @"products", Newname.ToLower());

                }
                if (string.IsNullOrEmpty(product.Thumb)) product.Thumb = "default.jpg";
                product.Alias = Utilities.SEOUrl(product.ProductsName);
                product.DateModifiled = DateTime.Now; 
                product.DateCreated = DateTime.Now;


                _context.Add(product);
                await _context.SaveChangesAsync();//Phương thức SaveChangesAsync  sau đây lưu thực thể product  vào cơ sở dữ liệu không đồng bộ.
                _notifyService.Success("Tạo mới thành công");
                RedirectToAction("Index", "Products");
            }
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductsId,ProductsName,ShortDesc,Description,CatId,Price,Discount,Thumb,Video,DateCreated,DateModifiled,BestSellers,HomeFlag,Active,Tags,Tiltle,Alias,MetaDesc,MetaKey,UnitslnStock")] Product product, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != product.ProductsId)
            {
                return NotFound();
            }
           
                if (ModelState.IsValid)
            {
                try
                {
                        product.ProductsName = Utilities.ToTitleCase(product.ProductsName);
                        if (fThumb != null)
                        {
                            string extension = Path.GetExtension(fThumb.FileName);
                            string Newname = Utilities.SEOUrl(product.ProductsName) + extension;
                            product.Thumb = await Utilities.UploadFile(fThumb, @"products", Newname.ToLower());

                        }
                        if (string.IsNullOrEmpty(product.Thumb)) product.Thumb = "default.jpg";
                        product.Alias = Utilities.SEOUrl(product.ProductsName);
                        product.DateModifiled = DateTime.Now;
                        product.DateCreated = DateTime.Now;
                        _context.Update(product);
                    await _context.SaveChangesAsync();
                    _notifyService.Success("Cập nhật thành công");
                    RedirectToAction("Index", "Products");

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductsId))
                    {

                        _notifyService.Success("Có lỗi xảy ra");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                RedirectToAction("Index", "Products", new { area = "Admin" });
            }
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductsId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]// để ngăn chặn các cuộc tấn công giả mạo yêu cầu trên nhiều trang web
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa thành công");
            return RedirectToAction("Index", "Products", new { area = "Admin" });
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductsId == id);
        }
    }
}
