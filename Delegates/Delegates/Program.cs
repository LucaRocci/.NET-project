using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate bool IsgreaterThan(int i1, int i2);

        static bool Confronta(int p1,int p2)
        {
            return p1 > p2;
        }


        static bool ConfrontaAbs(int p1, int p2)
        {
           // return (p1 >= 0 ? p1 : -p1)>(p2 >= 0 ? p2 : -p2);     // per prendere i valori assoluti
            return Math.Abs(p1) > Math.Abs(p2); // ->più leggibile
        }

        static void ShowResult(int s1,int s2,IsgreaterThan f)
        {
            Console.WriteLine(f(s1,s2));
        }

        static void Main(string[] args)
        {
            ShowResult(-9, 2, Confronta);
            ShowResult(-9, 2, ConfrontaAbs);
            Console.ReadLine();
        }
    }
}
