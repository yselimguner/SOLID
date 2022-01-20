using ConsoleApp1.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP.Validated.Concreate
{
    public class Et : IProduct
    {
        public string GetCookingInstructions()
        {
            return "Köfte";
        }
    }
}
