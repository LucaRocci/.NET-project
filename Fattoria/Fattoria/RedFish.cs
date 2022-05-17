using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
  class RedFish : Animal
  {
    public RedFish()
    {
      LegsNumber = 0;
      AnimalFamily = Family.Fishes;
      Name = "Pesce";
    }

    public override void Breath()
    {
      Console.WriteLine(Name + " boccheggia!");
    }
  }
}
