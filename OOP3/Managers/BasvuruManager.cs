using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP3.Abstract;

namespace OOP3.Managers
{
    class BasvuruManager
    {

        //ILoggerService ekleyerek Method Injection yapıyoruz.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //parametrede interface kullanarak tüm kredileri kullanabiliyoruz.
        {
            //Başvuran bilgilerini değerlendirme kodları vs...

            //KonutKredi manager yaparak tüm başvuruları konut kredisi için yaptık.

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        //
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Ne kadar kredi kullanılacağı belli olmadığı için List kullanılır.Listeyi de IKrediManager yaparız ki neyler ile liste oluşturacağımız belli olsun.
        {
            foreach (var kredi in krediler) //Listedeki her bir kredinin hesabını yap.
            {
                kredi.Hesapla();
            }
        }
    }
}
