using OOP3.Abstract;

namespace OOP3.Services
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı!!");
        }
    }
}
