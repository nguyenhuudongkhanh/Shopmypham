using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.ModelView
{
    public class ProductHomeVN
    {
        public Category Category { get; set; }
        public List<Product> lsProduct { get; set; }
    }
}
