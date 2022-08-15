using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Extensions;
using WebBanHangOnline.Helpper;
using WebBanHangOnline.Models;
using WebBanHangOnline.ModelView;

namespace WebBanHangOnline.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly BanHangOnlineContext _context;
        public INotyfService _notifyService { get; }
        public CheckoutController(BanHangOnlineContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoangID = HttpContext.Session.GetString("CustomersId");
            PurchaseVM model = new PurchaseVM();
            if (taikhoangID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().Include(a => a.Orders).SingleOrDefault(x => x.CustomersId == Convert.ToInt32(taikhoangID));
                model.CustomerId = khachhang.CustomersId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;
                //model.Note = Utilities.StripHTML(khachhang.Note);
            }
            ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "LocationId", "Name");
            ViewBag.GioHang = cart;

            return View(model);
        }
        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(PurchaseVM purchase)
        {

            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoangID = HttpContext.Session.GetString("CustomersId");
          
            if (string.IsNullOrEmpty(taikhoangID))
            {
                return RedirectToAction("Login", "Account");

            }

            PurchaseVM model = new PurchaseVM();
            if (taikhoangID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().Include(a => a.Orders).SingleOrDefault(x => x.CustomersId == Convert.ToInt32(taikhoangID));
                model.CustomerId = khachhang.CustomersId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;
                //model.Note = Utilities.StripHTML(khachhang.Note);

                khachhang.Address = purchase.Address;
                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    Order donhang = new Order();
                    donhang.CustomersId = model.CustomerId;
                    donhang.Address = model.Address;

                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 1;
                    donhang.Deleted = false;
                    donhang.Paid = false;
                    donhang.PaymentId = 2;
                    donhang.Price = Convert.ToInt32(cart.Sum(x => x.Price()));
                    donhang.Note = Utilities.StripHTML(model.Note);

                    donhang.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney()));
                    _context.Add(donhang);
                    _context.SaveChanges();

                    foreach (var item in cart)
                    {
                        OrdersDetail ordersDetail = new OrdersDetail();
                        ordersDetail.OrdersId = donhang.OrdersId;
                        ordersDetail.ProductsId = item.product.ProductsId;
                        ordersDetail.Amount = item.amount;
                        ordersDetail.Total = donhang.TotalMoney;
                        ordersDetail.Price = donhang.Price;
                        ordersDetail.ShipDate = DateTime.Today.AddDays(3);
                        ordersDetail.Discount = Convert.ToInt32(cart.Sum(x => x.Discount()));
                        ordersDetail.CreateDate = DateTime.Now;
                        _context.Add(ordersDetail);

                    }

                    //Xóa hết giỏ hàng


                    _context.SaveChanges();
                    HttpContext.Session.Remove("GioHang");
                    _notifyService.Success("Đơn đặt hàng thành công");
                    return RedirectToAction("Success");

                }
            }
            catch (Exception ex)
            {

                ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "LocationId", "Name");
                ViewBag.GioHang = cart;

                return View(model);
            }
            ViewData["lsTinhThanh"] = new SelectList(_context.Locations.Where(x => x.Levels == 1).OrderBy(x => x.Type).ToList(), "LocationId", "Name");
            ViewBag.GioHang = cart;
            ViewData["PaymentID"] = new SelectList(_context.Payments, "PaymentId", "Status");
            ViewBag.GioHang = cart;
            return View(model);
        }

        [Route("dat-hang-thanh-cong.html", Name = "Success")]
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult UnSuccess()
        {
            return View();
        }
    }
}
