using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Managers
{
    //Birisi bu interface kullanırsa alttaki metotları kullanmak zorunda.Interface anlaşılabilmesi için I harfi interface başına konur.
    //Interface de girilen metotları farklı classlarda implement ediyoruz her class metodlara karşılık kendi kodlarını kullanıyor implement sayesinde.
    //Genellikle interface de operasyonel metotlar kullanılır.

    //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.


    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

    }
}
