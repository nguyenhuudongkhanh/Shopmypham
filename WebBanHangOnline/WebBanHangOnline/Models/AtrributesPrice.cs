using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class AtrributesPrice
    {
        public int AtrributesPriceId { get; set; }
        public int? AtrributeId { get; set; }
        public int? ProductsId { get; set; }
        public int? Price { get; set; }
        public bool? Active { get; set; }

        public virtual Atrribute Atrribute { get; set; }
        public virtual Product Products { get; set; }
    }
}
