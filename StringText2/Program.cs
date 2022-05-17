using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringText2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            DateTime Inizio = DateTime.Now;  // ora di sistema
            for (int i = 0; i < 50000; i++)
                s = s + "1234567890";
            DateTime Fine = DateTime.Now;

            TimeSpan Durata = Fine - Inizio;
            //  TimeSpan Durata = Fine.Subtract(Inizio);  stessa cosa
            Console.WriteLine(Durata);

           //  Primo metodo non efficiente, il secondo con l'utilizzo dello StringBuilder
           

            StringBuilder sb = new StringBuilder();   // 
         Inizio = DateTime.Now;  // ora di sistema
            for (int i = 0; i < 50000; i++)
                sb.Append("1234567890");
         Fine = DateTime.Now;
       

          Durata = Fine - Inizio;
            //  TimeSpan Durata = Fine.Subtract(Inizio);  stessa cosa
            Console.WriteLine(Durata);
            Console.ReadLine();
        }
   
    }
}
