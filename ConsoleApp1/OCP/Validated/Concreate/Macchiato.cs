using ConsoleApp1.OCP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OCP.Validated.Concreate
{
    public class Macchiato : GoodCoffe
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 6.75;
        }
    }
}
