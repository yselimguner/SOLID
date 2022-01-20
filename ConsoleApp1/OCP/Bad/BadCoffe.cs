using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OCP.Bad
{


    public enum CoffeType
    {
        Latte ,
        Espresso ,
        Macchiato
    }

   public class BadCoffe
    {
        public  double  GetTotalPrice(double amount, CoffeType coffeType)
        {
            //Burada daha fazla kahve çeşidi eklenirse ,kodumuza bir tane daha else if bloğu eklemeniz gerekecek her biri için... 
            //Buda open /Close prensibini ihlal etmek demektdir...
            double totolPrice = 0;


            if (coffeType==CoffeType.Espresso)
            {
                totolPrice = amount * 4.50;
            }
            else if (coffeType==CoffeType.Latte)
            {
                totolPrice = amount * 5.25;

            }

            else if (coffeType==CoffeType.Macchiato)
            {
              totolPrice = amount * 6.75;
            }
            return totolPrice;

        }



    }
}
