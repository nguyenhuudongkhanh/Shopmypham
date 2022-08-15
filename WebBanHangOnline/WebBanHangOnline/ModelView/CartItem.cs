using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.ModelView
{
    public class CartItem
    {
        public Product product { get; set; }
        public int amount { get; set; }
        public Order order { get; set; }
        public double TotalMoney()
        {
            if (product.Discount != 0)

            {
                return amount * product.Discount.Value;
            }

            else
                return amount * product.Price.Value;
        }
        public double Price()
        {
            if (product.Price != 0)

            {
                return product.Price.Value;
            }
           
            else return 0;

        }

        public double Discount()
        {
            if (product.Discount != 0)

            {
                return product.Discount.Value;
            }
            else
                return 0;
        }

    }
}
