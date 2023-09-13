using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP3.Abstract;

namespace OOP3.Services
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Yollandı !!");
        }
    }
}
