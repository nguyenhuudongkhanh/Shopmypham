using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBanHangOnline.Extensions;
using WebBanHangOnline.Helpper;
using WebBanHangOnline.Models;
using WebBanHangOnline.ModelView;

namespace WebBanHangOnline.Controllers
{

    [Authorize]
    public class AccountController : Controller
    {
        private readonly BanHangOnlineContext _context;
        public INotyfService _notifyService { get; }
        public AccountController(BanHangOnlineContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone);
                if (khachhang != null)
                    return Json(data: "Số điện thoại:" + Phone + "Đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email);
                if (khachhang != null)
                    return Json(data: "Email:" + Email + "Đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }

        }
        [Route("tai-khoang-cua-toi.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var taikhoangID = HttpContext.Session.GetString("CustomersId");
            if (taikhoangID != null)
            {

                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomersId == Convert.ToInt32(taikhoangID));
                if (khachhang != null)
                {
                    var listorder = _context.Orders
                        .Include(x => x.TransactStatus)
                        .AsNoTracking()
                        .Where(x => x.CustomersId == khachhang.CustomersId)
                        .OrderByDescending(x => x.OrderDate).ToList();
                    ViewBag.ListOrder = listorder;
                    return View(khachhang);
                }


            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangKyTaiKhoang()
        {
            return View();

        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangKyTaiKhoang(RegisterVM taikhoan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Customer khachhang = new Customer
                    {
                        FullName = taikhoan.FullName,
                        Phone = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),
                        Address = taikhoan.Address.Trim().ToLower(),
                        Password = (taikhoan.Password + salt.Trim()).ToMD5(),
                        Active = true,
                        Salt = salt,
                        CreateDate = DateTime.Now
                    };
                    try

                    {
                        _context.Add(khachhang);
                        await _context.SaveChangesAsync();

                        HttpContext.Session.SetString("CustomersId", khachhang.CustomersId.ToString());
                        var taikhoangid = HttpContext.Session.GetString("CustomersId");
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,khachhang.FullName),
                            new Claim("CustomersId",khachhang.CustomersId.ToString())

                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        _notifyService.Success("Đăng ký thành công");
                        return RedirectToAction("Dashboard", "Account");
                    }
                    catch(Exception ex)
                    {

                        return RedirectToAction("DangKyTaiKhoang", "Account");
                    }


                }
                else
                {

                    return View(taikhoan);
                }

            }
            catch (Exception ex)
            {
                return View(taikhoan);
            }

        }

        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoangID = HttpContext.Session.GetString("CustomersId");
            if (taikhoangID != null)
            {
                return RedirectToAction("Dashboard", "Account");

            }
            //ViewBag.ReturnUrl = returnUrl;
            //ViewBag.ShoppingCarts = GioHang;
            return View();

        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(customer.Username);
                    if (!isEmail)
                        return View(customer);
                    var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == customer.Username);
                    if (khachhang == null) return RedirectToAction("DangKyTaiKhoang");
                    string pass = (customer.Password + khachhang.Salt.Trim()).ToMD5();
                    if (khachhang.Password != pass)
                    {
                        _notifyService.Success("Sai thông tin đăng nhập");
                        return View(customer);

                    }
                    if (khachhang.Active == false)
                        return RedirectToAction("ThongBao", "Account");

                    HttpContext.Session.SetString("CustomersId", khachhang.CustomersId.ToString());
                    var taikhoangId = HttpContext.Session.GetString("CustomerId");
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,khachhang.FullName),
                            new Claim("CustomersId",khachhang.CustomersId.ToString())

                        };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    _notifyService.Success("Đăng nhập thành công");
                    
                    return RedirectToAction("Dashboard", "Account");
                }


            }
            catch
            {
                return RedirectToAction("DangKyTaiKhoang", "Account");

            }
            return View(customer);

        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanId = (HttpContext.Session.GetString("CustomerId"));
                if (taikhoanId == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                if(ModelState.IsValid)
                {
                    var taikhoan = _context.Customers.Find(Convert.ToInt32(taikhoanId));
                    if (taikhoan == null) return RedirectToAction("Login", "Account");
                    var pass = (model.PasswordNow.Trim() + taikhoan.Salt.Trim()).ToMD5();
                    if (pass == taikhoan.Password)
                    {
                        string passnew = (model.Password.Trim() + taikhoan.Salt.Trim()).ToMD5();
                        taikhoan.Password = passnew;
                        _context.Update(taikhoan);
                        _context.SaveChanges();
                        _notifyService.Success("Đổi thông tin thành công");
                        return RedirectToAction("Dashboard", "Account");


                    }

                }
               
            }

            catch
            {
                _notifyService.Success("Đổi thông tin thất bại");
                return RedirectToAction("Dashboard", "Account");
            }
            _notifyService.Success("Đổi thông tin thất bại");
            return RedirectToAction("Dashboard", "Account");
        }
        [HttpGet]
        [Route("dang-xuat.html", Name = "Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomersId");
            return RedirectToAction("Index", "Home");

        }
    }
}
