using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
  class Turkey : Animal
  {
    public Turkey()
    {
      LegsNumber = 2;
      AnimalFamily = Family.Birds;
      Name = "Tacchino";
    }

    public void Talk()
    {
      Console.WriteLine("GLU GLU!");
    }

    public override void Breath()
    {
      Console.WriteLine(Name + " glu-glu-eggiando!");
    }
  }
}
