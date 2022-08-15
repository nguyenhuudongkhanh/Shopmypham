using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class DeliveryAddress
    {
        public int AddressId { get; set; }
        public int? CustomersId { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public virtual Customer Customers { get; set; }
    }
}
