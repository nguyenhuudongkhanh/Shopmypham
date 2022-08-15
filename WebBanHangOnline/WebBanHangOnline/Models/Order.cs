using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class Order
    {
        public Order()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        public int OrdersId { get; set; }
        public int? CustomersId { get; set; }
        public int? ShipperId { get; set; }
        public int? Price { get; set; }
        public string Address { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? TransactStatusId { get; set; }
        public bool Deleted { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentId { get; set; }
        public string Note { get; set; }
        public int? TotalMoney { get; set; }

        public virtual Customer Customers { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual TransactStatus TransactStatus { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
