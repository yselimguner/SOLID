using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ISP.Bad
{
    public class BadHawk : IBird //=>Şahin
    {
        public string Fly()
        {
            return "Bu şahin Uçabilir.";
        }

        public string Walk()
        {
            return "Bu şahin yürüyebilir.";
        }
    }
}
