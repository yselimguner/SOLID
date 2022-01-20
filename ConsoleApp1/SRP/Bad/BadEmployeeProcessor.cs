using ConsoleApp1.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SRP.Bad
{
    public class BadEmployeeProcessor
    {


        public void InsertEmployee(Employee newemployee)
        {
            StringBuilder sb = new StringBuilder();


            try
            {
                sb.Append(newemployee.Id);
                sb.AppendLine();
                sb.Append(newemployee.FirstName);
                sb.AppendLine();
                sb.Append(newemployee.LastName);
                sb.AppendLine();
                sb.Append(newemployee.HireDate);
                sb.AppendLine();

                File.WriteAllText(@"C:\Test\EmployeeData.txt", sb.ToString());


                sb = new StringBuilder();
                sb.Append("Kayıt Ekleme Tarihi :");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("PersonelId: ");
                sb.Append(newemployee.Id);
                sb.Append(newemployee.FirstName).Append(" ");
                sb.Append(newemployee.LastName);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());


                Console.WriteLine("Çalışan Başarı ile kaydedildi .");

            }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Hata Tarihi");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata mesajıdır: ");
                sb.Append(ex.Message);

                File.WriteAllText(@"C:Test\Log.txt", sb.ToString());
                Console.WriteLine("Hata");
            }



        }





    }
}
