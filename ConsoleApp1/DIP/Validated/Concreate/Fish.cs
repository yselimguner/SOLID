using ConsoleApp1.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP.Validated.Concreate
{
    class Fish : IProduct
    {
        public string GetCookingInstructions()
        {
            return "balik";
        }
    }
}
