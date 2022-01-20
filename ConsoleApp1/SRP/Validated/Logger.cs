using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SRP.Validated
{
   public class Logger
    {
        public void LogFile(string filePath, string log)
        {
            File.WriteAllText(filePath, log);
        }

        public string BuildLog(string informantion)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Bilgilendirme : ").Append(informantion);
            return sb.ToString();
        }



    }
}
