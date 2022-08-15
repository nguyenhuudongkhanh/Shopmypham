using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly BanHangOnlineContext _context;

        public OrdersController(BanHangOnlineContext context)
        {
            _context = context;
        }

        // GET: Admin/Orders
        public IActionResult Index(int? page,int TransactStatusID=0)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;

            List<Order> lstcategory = new List<Order>();
            if(TransactStatusID!=0)
            {
                lstcategory = _context.Orders.Where(a=>a.TransactStatusId==TransactStatusID).Include(o => o.Customers)
                .Include(o => o.TransactStatus).Include(a=>a.Payment)
                .AsNoTracking().OrderByDescending(x => x.OrderDate).ToList();
            }    
          else
            {
                lstcategory = _context.Orders.Include(o => o.Customers)
               .Include(o => o.TransactStatus).Include(a => a.Payment)
               .AsNoTracking().OrderByDescending(x => x.OrderDate).ToList();
            }    
            PagedList<Order> models = new PagedList<Order>(lstcategory.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentTransactStatusID = TransactStatusID;
            ViewBag.CurrentPage = pageNumber;
            ViewData["CatId"] = new SelectList(_context.Categories, "TransactStatusId", "Status", TransactStatusID);
            return View(models);

        }
        public IActionResult Filtter(/*int? page*/ int TransactStatusID = 0/* int Active = 0*/)
        {
            //var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var url = $"/Admin/Orders?TransactStatusID={TransactStatusID}";
            if (TransactStatusID == 0)
            {
                url = $"/Admin/Orders";

            }
            //else
            //{

            //    if (Active == 0) url = $"/Admin/Products?CatID={CatID}";
            //    if (CatID == 0) url = $"/Admin/Products?Active={Active}";
            //}

            return Json(new { status = "succsess", redirectUrl = url });

        }


        public async Task<IActionResult> SendMail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customers)
                .Include(o => o.TransactStatus).Include(a => a.Payment)
                .FirstOrDefaultAsync(m => m.OrdersId == id);
            if (order == null)
            {
                return NotFound();
            }

            var orderDetail = _context.OrdersDetails.Include(x => x.Products)
                .AsNoTracking().Where(x => x.OrdersId == order.OrdersId)
                .OrderBy(x => x.OrdersDetailsId).ToList();

            return RedirectToAction("Detail","Orders",new {id=order.OrdersId});
        }
        // GET: Admin/Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customers)
                .Include(o => o.TransactStatus).Include(a => a.Payment)
                .FirstOrDefaultAsync(m => m.OrdersId == id);
            if (order == null)
            {
                return NotFound();
            }

            var orderDetail = _context.OrdersDetails.Include(x => x.Products)
                .AsNoTracking().Where(x => x.OrdersId == order.OrdersId)
                .OrderBy(x => x.OrdersDetailsId).ToList();
            ViewBag.Detail = orderDetail;

         
            return View(order);
        }
        public async Task<IActionResult> ChangesStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.AsNoTracking().Include(x => x.Customers).FirstOrDefaultAsync((m => m.OrdersId == id));
            if (order == null)
            {
                return NotFound();
            }
            ViewData["TransactStatusId"] = new SelectList(_context.TransactStatuses, "TransactStatusId", "Status", order.TransactStatusId);

            return PartialView("ChangesStatus", order);
        }
        [HttpPost]

        public async Task<IActionResult> ChangesStatus(int id, [Bind("OrdersId,CustomersId,OrderDate,ShipDate,TransactStatusId,Deleted,Paid,PaymentDate,PaymentId,Note,TotalMoney,Address,Price")] Order order)
        {
            if (id != order.OrdersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var donhang = await _context.Orders.AsNoTracking().Include(x => x.Customers).FirstOrDefaultAsync((m => m.OrdersId == id));
                    if (donhang == null)
                    donhang.Paid = order.Paid;
                    donhang.Deleted = order.Deleted;
                    donhang.TransactStatusId = order.TransactStatusId;
                    if(donhang.Paid==true)
                    {
                        donhang.PaymentDate = DateTime.Now;
                    }
                    if (donhang.TransactStatusId == 5) donhang.Deleted = true;
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrdersId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomersId"] = new SelectList(_context.Customers, "CustomersId", "CustomersId", order.CustomersId);
            ViewData["TransactStatusId"] = new SelectList(_context.TransactStatuses, "TransactStatusId", "TransactStatusId", order.TransactStatusId);
            return View(order);
        }
        // GET: Admin/Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomersId"] = new SelectList(_context.Customers, "CustomersId", "CustomersId");
            ViewData["TransactStatusId"] = new SelectList(_context.TransactStatuses, "TransactStatusId", "TransactStatusId");
            return View();
        }

        // POST: Admin/Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrdersId,CustomersId,OrderDate,ShipDate,TransactStatusId,Deleted,Paid,PaymentDate,PaymentId,Note,TotalMoney,Address,Price")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomersId"] = new SelectList(_context.Customers, "CustomersId", "CustomersId", order.CustomersId);
            ViewData["TransactStatusId"] = new SelectList(_context.TransactStatuses, "TransactStatusId", "TransactStatusId", order.TransactStatusId);
            return View(order);
        }

        // GET: Admin/Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            var orderDetail = _context.OrdersDetails.Include(x => x.Products)
                .AsNoTracking().Where(x => x.OrdersId == order.OrdersId)
                .OrderBy(x => x.OrdersDetailsId).ToList();
            ViewBag.Detail = orderDetail;

            ViewData["TransactStatusId"] = new SelectList(_context.TransactStatuses, "TransactStatusId", "Status", order.TransactStatusId);
            ViewData["PaymentID"] = new SelectList(_context.Payments, "PaymentId", "Status", order.PaymentId);
            return View(order);
        }

        // POST: Admin/Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrdersId,CustomersId,OrderDate,ShipDate,TransactStatusId,Deleted,Paid,PaymentDate,PaymentId,Note,TotalMoney,Address,Price")] Order order)
        {
            if (id != order.OrdersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //if (order.TransactStatusId == 3) order.ShipDate = DateTime.Today.AddDays(2);
                    //if (order.TransactStatusId == 4) order.ShipDate = null;
                    if (order.PaymentId == 2 ) order.PaymentDate = DateTime.Today.AddDays(2); 
                    if ( order.PaymentId == 1 || order.PaymentId==3 ) order.PaymentDate = DateTime.Now;
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrdersId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["CustomersId"] = new SelectList(_context.Customers, "CustomersId", "CustomersId", order.CustomersId);
            ViewData["TransactStatusId"] = new SelectList(_context.TransactStatuses, "TransactStatusId", "Status", order.TransactStatusId);
            ViewData["PaymentID"] = new SelectList(_context.Payments, "PaymentId", "Status", order.PaymentId);
            return View(order);
        }

        // GET: Admin/Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customers)
                .Include(o => o.TransactStatus)
                .FirstOrDefaultAsync(m => m.OrdersId == id);
            if (order == null)
            {
                return NotFound();
            }

            var orderDetail = _context.OrdersDetails.Include(x => x.Products)
                .AsNoTracking().Where(x => x.OrdersId == order.OrdersId)
                .OrderBy(x => x.OrdersDetailsId).ToList();
            ViewBag.Detail = orderDetail;


            return View(order);
        }

        // POST: Admin/Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            order.Deleted = true;
            order.TransactStatusId=5;
            _context.Update(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrdersId == id);
        }
    }
}
