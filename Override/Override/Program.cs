using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
  class Program
  {
    static void Main(string[] args)
    {
      B b = new B();
      A ab = b;

      b.M();   // otterrò "B"
      ab.M();  // otterrò "B"
      Console.WriteLine();

      /////////
      
      D d = new D();
      C cd = d;
      B bd = d;
      A ad = d;

      d.M();   // otterrò "D"
      cd.M();  // otterrò "D"
      bd.M();  // otterrò "B"
      ad.M();  // otterrò "B"
      Console.ReadLine();
    }
  }
}
