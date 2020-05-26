using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class lib
    {
        public static void ShowSystemInfo()
        {
            Console.WriteLine("Сведения о системе:");
            Console.WriteLine("\tОперационная система:  {0}", Environment.OSVersion);
            Console.WriteLine("\tИмя пользователя: {0}", Environment.UserName);
            Console.WriteLine("\tНазвание ПК по биосу:  {0}", Environment.MachineName);
            Console.WriteLine("\tВремя с первой загрузки ПК (сек):  {0}", Environment.TickCount / 1000);
            Console.WriteLine("\tИмя сетевого домена:  {0}", Environment.UserDomainName);
            Console.WriteLine();

            Console.WriteLine("Сведения о Процессоре:");
            Console.ResetColor();
            Console.WriteLine("\tМодель процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            Console.WriteLine("\tРазрядность процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            Console.WriteLine("\tНомер модели процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_LEVEL"));
            Console.WriteLine("\tЧисло процессоров:  {0}", Environment.ProcessorCount);
        }
    }
}
