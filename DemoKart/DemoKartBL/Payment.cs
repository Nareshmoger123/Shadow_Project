using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Payment
    {
        enum Mode { ByCash=1,ByCard}
        public double CalculateCGST(int num, double price)
        {
            if (num == (int)Mode.ByCash)
            {
                double Price = 0;
                Price = price;
                return Price;
            }
            else
            {
                double Price = 0;
                Price = price + (price * 0.035) ;
                return Price;
            }   
        }
        public double CalculateSGST(int num, double price)
        {
            if (num == (int)Mode.ByCash)
            {
                double Price = 0;
                Price = price ;
                return Price;
            }
            else
            {
                double Price = 0;
                Price = price + (price * 0.035 );
                return Price;
            }
        }
    }
}
