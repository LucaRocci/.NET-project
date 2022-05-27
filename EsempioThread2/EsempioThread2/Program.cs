using System;
using System.Configuration;
using System.Threading;

namespace EsempioThread2
{
    class Program
    {
        static int Temporizzazione1;
        static int Temporizzazione2;

        static void Main(string[] args)
        {

            Temporizzazione1 = int.Parse(ConfigurationManager.AppSettings["Temporizzazione1"]);

            Temporizzazione2 = int.Parse(ConfigurationManager.AppSettings["Temporizzazione2"]);

            Thread t = new Thread(new ThreadStart(Contatore2));

            t.Start();

            Console.WriteLine("Thread primario running...");

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("T1: " + i.ToString());
                System.Threading.Thread.Sleep(Temporizzazione1);
            }
            t.Join();
            Console.WriteLine("Thread primario terminato.");

            Console.ReadLine();
        }

        static void Contatore2()
        {
            Console.WriteLine("Thread secondario running...");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("T2: " + i.ToString());
                System.Threading.Thread.Sleep(Temporizzazione2);
            }
        }
    }
}
