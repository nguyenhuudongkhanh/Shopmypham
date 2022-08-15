using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.ModelView
{
    public class ViewOrder
    {
        public Order order { get; set; }
        public List<OrdersDetail> ordersDetail { get; set; }
    }
}
