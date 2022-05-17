using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringText3103
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string t1 = (string)s1.Clone();  //Clone comune a tutti gli oggetti 
            string t2 = s1;
            string t3 = string.Copy(s1);
            string t4 = "Hello";
            string t5 = "HELLO";

            Console.WriteLine("s1==t1 "+(s1 == t1).ToString());
            Console.WriteLine("s1.Equals(t1): " + (s1.Equals(t1)).ToString());                
            Console.WriteLine("Object.ReferenceEquals(s1, t1) -> " + Object.ReferenceEquals(s1, t1).ToString());// cerco se i puntatori sono uguali
            Console.WriteLine("Object.ReferenceEquals(s1, t2) -> " + Object.ReferenceEquals(s1, t2).ToString());  // true 
            Console.WriteLine("Object.ReferenceEquals(s1, t3) -> " + Object.ReferenceEquals(s1, t3).ToString()); // true
            Console.WriteLine("Object.ReferenceEquals(s1, t4) -> " + Object.ReferenceEquals(s1, t4).ToString());  //false 
            Console.WriteLine("Object.ReferenceEquals(s1, t5) -> " + Object.ReferenceEquals(s1, t5).ToString());   //true 
  
            t2 += "x";     //  -> t2=  t2 + "x"  cambio valore

            Console.WriteLine("s1= " + s1);    //stampa hello 
            Console.WriteLine("t2= " + t2);     // stampa hellox
            Console.WriteLine("Object.ReferenceEquals(s1, t2) -> " + Object.ReferenceEquals(s1, t2).ToString());  //   false  due cose diverse

            Console.ReadLine();

        }
    }
}
