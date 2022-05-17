using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
  abstract class Animal   //  
  {
    public string Name;
    public Family AnimalFamily;
    protected int LegsNumber;

    public int Legs  //in sola lettura
    {
      get
      {
        return LegsNumber;
      }
    }


    public abstract void Breath();

  }

  public enum Family 
  {
    Mammals,
    Birds,
    Anfibio,
    Fishes
  }

}
