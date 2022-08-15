using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class Product
    {
        public Product()
        {
            AtrributesPrices = new HashSet<AtrributesPrice>();
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public int? CatId { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        public string Thumb { get; set; }
        public string Video { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModifiled { get; set; }
        public bool BestSellers { get; set; }
        public bool HomeFlag { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public string Tiltle { get; set; }
        public string Alias { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public int? UnitslnStock { get; set; }

        public virtual Category Cat { get; set; }
        public virtual ICollection<AtrributesPrice> AtrributesPrices { get; set; }
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
