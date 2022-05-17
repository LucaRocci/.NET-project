using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proveArray07042022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[4];
            int[] a2 = a1;
            a1[0] = 123;
            //    Console.WriteLine(a2[0]);   //123
            ModificaArray(a1);
            for (int i = 0; i < a1.Length; i++)    //passa per indirizzo 
                Console.WriteLine(a1[i]);
            //string s1 = "pippo";
            //string s2 = s1;
            //s1 = "Pluto";
            ////  Console.WriteLine(s2);  //pippo

            //string frutta = "fragola banana mela kiwi pera ananas";
            //string[] frutti = frutta.Split(' ');  //crea un array di stringhe frutti splittando la stringa frutta
            ////for (int i = 0; i < frutti.Length; i++)
            ////   Console.WriteLine(frutti[i]);
            //System.Array.Sort(frutti);

            //frutta = string.Join(" ", frutti);
            //Console.WriteLine(frutta);

            ////foreach (string f in frutti)
            ////    if(!f.StartsWith("b"))
            ////Console.WriteLine(f);

            int p = 1234;
            ModificaIntero( p);    //passa per valore 
            Console.WriteLine(p);
            Console.ReadLine();

        }

        static void ModificaArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = i;
        }

        static void ModificaIntero( int x)
        {
            x = 999;
        }


    }
}
