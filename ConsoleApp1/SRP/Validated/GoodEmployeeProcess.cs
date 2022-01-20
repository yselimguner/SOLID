using ConsoleApp1.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SRP.Validated
{
    public class GoodEmployeeProcess
    {

        Logger logger;
        string log;

        public GoodEmployeeProcess()
        {
            logger = new Logger();
        }


        //Gördüğünüz üzere insertemployee sadece  veri girişişnden sorumlu hale geldi..
        //Son adım olarak    buradaki metodu bize bilgi verecek şekilde güncellliyelim ..
       // bool tipine cevirerek ekrana yazdırma kodunu siliniz... 
       //uNİT TEST İÇİN Faydalıdır



        public bool İnsertEmployee(Employee newemployee)
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

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Test\EmployeeData.txt", log);



                sb = new StringBuilder();
                sb.Append("Kayıt Ekleme Tarihi :");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("PersonelId: ");
                sb.Append(newemployee.Id);
                sb.Append(newemployee.FirstName).Append(" ");
                sb.Append(newemployee.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Test\Log.txt", log);


                return true;

            }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Hata Tarihi");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata mesajıdır: ");
                sb.Append(ex.Message);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Test\Log.txt", log);


                return false;
            }

        }
    }
}
