using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Category
    {
 

        public int categoriesId { get; set; }
        public String categories { get; set; }

        public double totalPrice = 0;
        public Category()
        {
            categories = null;
        }
        public Category(int categoriesId, String categories)
        {
            this.categories = categories;
            this.categoriesId = categoriesId;
        }


        public double CalculatePrice(int type, double price,int Quantity)
        {
            if (type == 1)
            {
                price = price * Quantity;
                totalPrice = price + (price * 0.18);
                return totalPrice;
            }
            else if (type == 2)
            {
                price = price * Quantity;
                totalPrice = price + ( price * 0.04);
                return totalPrice;
            }
            else if (type == 3)
            {
                price = price * Quantity;
                totalPrice = price + (price * 0.07);
                return totalPrice;
            }
            else if (type == 4)
            {
                price = price * Quantity;
                totalPrice = price + (price * 0.18);
                return totalPrice;
            }
            else
            {
                return 0;
            }
        }

    }
}

