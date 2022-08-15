using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Extensions;
using WebBanHangOnline.Models;
using WebBanHangOnline.ModelView;

namespace WebBanHangOnline.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly BanHangOnlineContext _context;
        public INotyfService _notifyService { get; }
        public ShoppingCartController(BanHangOnlineContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }


        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddtoCart(int productId, int? amount)
        {
            List<CartItem> giohang = GioHang;

            try
            {
                CartItem cartItem = GioHang.SingleOrDefault(p => p.product.ProductsId == productId);
                if (cartItem != null)
                {

                    if (amount.HasValue)
                    {
                        cartItem.amount = amount.Value;
                    }
                    else
                    {
                        cartItem.amount++;
                    }
                }
                else
                {
                    Product product = _context.Products.SingleOrDefault(p => p.ProductsId == productId);
                    cartItem = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = product
                    };
                    giohang.Add(cartItem);
                }

                HttpContext.Session.Set<List<CartItem>>("GioHang", giohang);
                _notifyService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }

        }

        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productId, int? amount)
        {
            var cartItem = HttpContext.Session.Get<List<CartItem>>("GioHang");

            try
            {
               
                if (cartItem != null)
                {

                    CartItem item = cartItem.SingleOrDefault(p => p.product.ProductsId == productId);
                    if(item !=null && amount.HasValue)
                    {
                        item.amount = amount.Value;
                    }
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cartItem);
                }

               
                _notifyService.Success("Cập nhật sản phẩm thành công");
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }

        }
        [HttpPost]
        [Route("api/cart/remove")]
        public ActionResult Remove(int productId)
        {

            try
            {
                List<CartItem> giohang = GioHang;
                CartItem item = giohang.SingleOrDefault(p => p.product.ProductsId == productId);
                if (item != null)
                {
                    giohang.Remove(item);
                }
                HttpContext.Session.Set<List<CartItem>>("GioHang", giohang);
                _notifyService.Success("Xóa sản phẩm thành công");
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }

        }
        public List<CartItem> GioHang
        {

            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {

                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        [Route("cart.html", Name = "Cart")]
        public IActionResult Index()
        {

            /*    List<int> lsProductIDs = new List<int>();*/
            var lsGioHang = GioHang;
            return View(GioHang);
                

            
        }
    }
}
