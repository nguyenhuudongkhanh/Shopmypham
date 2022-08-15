using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Extensions;
using WebBanHangOnline.ModelView;

namespace WebBanHangOnline.Controllers.Component
{
    public class NumberCartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");          
            return View(cart);
        }
    }
}
