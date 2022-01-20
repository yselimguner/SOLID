using ConsoleApp1.DIP.Validated.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DIP.Bad
{
    public class BadRestaurant
    {

        //Restaurant sınıfı high level bir modüldür.Yanlız lo-level modüllerden fish ve poulty sınıflarına bağımlıdır. Dependecy inversion prenssibine göre değişiklikleri gerçekeleştirelim ..

        BadFish tuna = new BadFish();
        BadPoultry duck = new BadPoultry();
        Et et1 = new Et();


         public string GenerateInstructions() //  Talimat oluşturudum... 
        {
            return tuna.GetFishCookingInstructions() + " " + duck.GetPoulrtyCookingInstructions() + et1.GetCookingInstructions();  
        }


      

    }
}
