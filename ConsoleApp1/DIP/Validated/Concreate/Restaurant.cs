using ConsoleApp1.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP.Validated.Concreate
{
  public  class Restaurant
    {
        private List<IProduct> products;

        public Restaurant(List<IProduct> products)
        {
            this.products = products;
        }


        public string GenerateInstructions() //  Talimat oluşturudum... 
        {
            string instructions = string.Empty;

            foreach (var item in products)
            {
                instructions+= item.GetCookingInstructions();
            }

            return instructions;
        }


    }
}
