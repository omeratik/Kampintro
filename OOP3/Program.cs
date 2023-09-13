using System.Collections.Generic;
using OOP3.Abstract;
using OOP3.Managers;
using OOP3.Services;

namespace OOP3
{
    internal class Program
	{
		static void Main(string[] args)
		{
			IKrediManager ihtiyaçKrediManager = new IhtiyacKrediManager();
			IKrediManager tasitKrediManager = new TasitKrediManager();
			IKrediManager konutKrediManager = new KonutKrediManager();
			
			ILoggerService databaseLoggerService = new DatabaseLoggerService();
			ILoggerService fileLoggerService = new FileLoggerService();
			
			
			
			BasvuruManager basvuruManager = new BasvuruManager();

			List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
			
			
			
			//parametre içerisinde tasitKrediManager yerine konut ve ihtiyacı koyabiliyoruz. fileLoggerService yerine data veya file koyabiliyoruz bu bize sürdürülebilirlik sağlıyor.
			
			//basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> {new DatabaseLoggerService() , new SmsLoggerService()}); // parametre içerisinde newleyebiliriz yani new DatabaseLoggerService() yazabiliriz aynı şey.
			basvuruManager.BasvuruYap(ihtiyaçKrediManager, loggers); // iki farklı şekilde de intence kullanılabilir.
			
			//basvuruManager.BasvuruYap(konutKrediManager);
			//basvuruManager.BasvuruYap(tasitKrediManager);

			List<IKrediManager> krediler = new List<IKrediManager> () {ihtiyaçKrediManager, tasitKrediManager };
			//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

			//Yukardakiler ekrandır.
			
			//Interfaceler onu implement eden class ın referansını tutabilir.
		
		
		}

	}
}