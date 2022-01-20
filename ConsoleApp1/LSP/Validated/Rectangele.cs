using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP.Validated
{
  public  class Rectangele:Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RectangleArea()
        {
            return Width * Height;
        }
    }
}
