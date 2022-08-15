using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class OrdersDetail
    {
        public int OrdersDetailsId { get; set; }
        public int? OrdersId { get; set; }
        public int? ProductsId { get; set; }
        public int? OrderNumber { get; set; }
        public int? Amount { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        public int? Total { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Order Orders { get; set; }
        public virtual Product Products { get; set; }
    }
}
