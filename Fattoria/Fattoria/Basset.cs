using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
  class Basset : Dog
  {
    public Basset()
    {
      Name = "Bassotto";
    }

    public Basset(string n)
    {
      Name = n;
    }

    public override void Breath()
    {
      Console.WriteLine(Name + " bassottando!");
    }
  }
}
