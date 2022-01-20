using ConsoleApp1.ISP.Validated.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ISP.Validated.Concreate
{
    public class GoodWawk : IFlyingBird,IFlighlessBird
    {
        public string Fly()
        {
            return "Bu şahin uçabilir...";
        }

        public string Walk()
        {
            return "Bu şahin yürüyebilirde";
        }
    }
}
