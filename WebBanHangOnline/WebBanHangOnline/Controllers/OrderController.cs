using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;
using WebBanHangOnline.ModelView;

namespace WebBanHangOnline.Controllers
{
    public class OrderController : Controller
    {
        private readonly BanHangOnlineContext _context;
        public INotyfService _notifyService { get; }
        public OrderController(BanHangOnlineContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var customerId = HttpContext.Session.GetString("CustomerId");
                if (string.IsNullOrEmpty(customerId)) return RedirectToAction("Login", "Account");
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomersId == Convert.ToInt32(customerId));
                if (customer == null) return NotFound();
                var order = await _context.Orders.Include(x => x.TransactStatus).FirstOrDefaultAsync(m => m.OrdersId == id && Convert.ToInt32(customerId) == m.CustomersId);
                if (order == null)
                {
                    return NotFound();
                }
              
                var ordersDetails = _context.OrdersDetails
                     .Include(x => x.Products)
                     .AsNoTracking()
                     .Where(x => x.OrdersId == id)
                     .OrderBy(x => x.OrdersDetailsId)
                     .ToList();
                ViewOrder Order = new ViewOrder();
                Order.order = order;
                Order.ordersDetail = ordersDetails;
                return PartialView("Details", order);

            }
            catch
            {

                return NotFound();
            }

        }
    }
}
