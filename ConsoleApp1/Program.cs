using ConsoleApp1.DIP.Bad;
using ConsoleApp1.DIP.Validated.Abstract;
using ConsoleApp1.DIP.Validated.Concreate;
using ConsoleApp1.ISP.Bad;
using ConsoleApp1.ISP.Validated.Concreate;
using ConsoleApp1.LSP.Bad;
using ConsoleApp1.LSP.Validated;
using ConsoleApp1.OCP.Validated.Abstract;
using ConsoleApp1.OCP.Validated.Concreate;
using ConsoleApp1.SRP.Bad;
using ConsoleApp1.SRP.Model;
using ConsoleApp1.SRP.Validated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BadEmployeeProcessor bt = new BadEmployeeProcessor();
            //bt.InsertEmployee(new Employee
            //{
            //    FirstName = "Mehmet ",
            //    LastName = "tas",
            //    HireDate = DateTime.Now,
            //    Id = 1

            //});

            //Solid Presipleri =>> solid ,beş öenmli  prensibi bulunur. 
            //Temiz ,modüler,ve genişletilebilir. kod yazımına önemli kuralalr getirir. 
            //Aynı zamanda agile /Adaptive yazılım gelişt,irme için kullanılır..


            Employee newemployee = new Employee();
            newemployee.Id = 1;
            newemployee.FirstName = "Bilge";
            newemployee.LastName = "Adam";
            newemployee.HireDate = new DateTime(1997, 1, 1);


            GoodEmployeeProcess process = new GoodEmployeeProcess();


            Console.WriteLine( process.İnsertEmployee(newemployee)?"Başarılı":"Hata");
            


            //Ocp =>> Open Closed Princeple 
            //Sınıflar ve metotlar gennişletilmeye açık değişikliğe kapaılı olmalıdırç 
            //Her ihtiyac deişikliğinde ,yazdığımız kodu değiştirmek zorunda kalmamak
            //işlermizi uzun  vadede rahatladır. 


            GoodCoffe kahve1 = new Espresso();
            GoodCoffe kahve2 = new Macchiato();
            GoodCoffe kahve3 = new Latte();


            double price = 0;

            price = kahve1.GetTotalPrice(20);
            Console.WriteLine("Kahve Fiyatı : " + price);
            price = kahve2.GetTotalPrice(20);
            Console.WriteLine("Kahve Fiyatı : " + price);
            price = kahve3.GetTotalPrice(20);

            Console.WriteLine("Kahve Fiyatı : "+price);

          

            BadRectangle rectangle = new BadRectangle();
            rectangle.Width = 2;
            rectangle.Height = 3;


            if (BadAreaCalculator.CalculateArea(rectangle)!=6)
            {
                Console.WriteLine("Dörtgen alan hesaplama işleminde hata var .");



            }

            //Square için deneyeleim ..


            BadSquare badSquare = new BadSquare();
            badSquare.Height = 3;

            if (BadAreaCalculator.CalculateArea(badSquare)!=9)
            {
                Console.WriteLine("Kare alan hesaplamasında hatalı işlem");
            }



            BadRectangle rectangle1 = new BadSquare(); //Squeare

            rectangle1.Height = 4;
            rectangle1.Width = 6;

            if (BadAreaCalculator.CalculateArea(rectangle1)!=24)
            {
                Console.WriteLine("Hata!!!!");
            }

            //Üsteki Kod hata verecek ...
        
            Rectangele rectangele = new Rectangele();
            rectangele.Width = 2;
            rectangele.Height = 3;

            if (rectangele.RectangleArea()!=6)
            {
                Console.WriteLine("Dörtgen hesaplamasında hata");
            }

            Square square = new Square();
            square.Width = 4;
            if (square.SquareArea()!=16)
            {
                Console.WriteLine("Kare Alan hesaplamasında hatalı işlem.... ");
            }


            //Isp =>> İnterface segragtion Principle 
            //Sınıflar ihtiyacları olmayan özellik ve davranışlarıo içeren interfaceleri alamamalıdırşar .


            //BadChicken badChicken = new BadChicken();
            //badChicken.Walk();

            GoodChicken goodChicken = new GoodChicken();
            goodChicken.Walk();

            GoodWawk wawk = new GoodWawk();
            Console.WriteLine(wawk.Fly());
            Console.WriteLine( wawk.Walk());



            //Dıp=>> Dependency Inversion Principle 
            //Üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır. 

            List<IProduct> urunler = new List<IProduct>();

            Fish fsh = new Fish();
            Poulty poulty1 = new Poulty();

            urunler.Add(fsh);
            urunler.Add(poulty1);

            Restaurant restaurant = new Restaurant(urunler);
            Console.WriteLine(restaurant.GenerateInstructions());


            Restaurant restaurant1 = new Restaurant(new List<IProduct>()

            {
                new Et()
            });

            Console.WriteLine(restaurant1.GenerateInstructions());



            BadRestaurant bdf = new BadRestaurant();
            Console.WriteLine(bdf.GenerateInstructions());

            Console.ReadLine();



        }
    }
}
