using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> list = new List<Worker>
            {
                new Worker("Yury", "Bolbukou", 18, "Oktyabrya, 48a", "BI", "trainee", "+375293595413", 25),
                new Worker("Stanislav", "Ivanov", 25, "Gagarina, 20", "BI", "junior", "+375441158736", 154),
                new Worker("QWERTYUI", "YCFVGYBKHN", 22, "RDCTFVGBHN", "CTVGYBHUN", "OIJL", "684526454", 98),
                new Worker("fdghjkjh", "dfghjjkh", 20, "efdghkj", "drtyuk", "iokjhg", "123456789", 74),
                new Worker("Ivan", "Apekunov", 18, "Chekalova, 22", "BI", "trainee", "+375291748933", 120)
            };
            try
            {
                list.Add(new Worker("Stanislav", "Verevkin", 12, "Masurova, 25", "BI", "trainee", "+375298745214", 50));
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("List of workers:");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
