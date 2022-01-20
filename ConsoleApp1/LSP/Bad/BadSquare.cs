using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LSP.Bad
{

    //Karalerde birer dörtgen oldukları için alttaki yöntemi izlememiz yanlış olamayacaktır.
    //Yanlız görtgen yerine kare sınıfıı kullandığımızda  işlemler istediğimiz gibi sonuçlanmayacaktır...
    //Bunun nedeni kodun yazım biçimi solid presnplerine uyamamaktadır...


    public class BadSquare : BadRectangle
    {
        int _heigth;
        int _width;



        public override int Height
        {

            get
            {
                return _heigth;
            }
            set
            {
                _heigth = value;
                _width = value;
            }
        }

        public override int Width
        {
            get
            {
                return _width;

            }
            set
            {
                _heigth = value;
                _width = value;

            }

        }
    }
}
