using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            IKrediManager tasitKrediManager = new TasitKrediManager();          
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            ILogerService dataBaseLogerService = new DataBaseLoggerService();
            ILogerService fileLoggerService = new FileLoggerService();
            
            //List<ILogerService> loggers = new List<ILogerService> { new FileLoggerService , new SmsLoggerService  }    
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager , new  List<ILogerService> { new DataBaseLoggerService()
                , new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,
                tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
 