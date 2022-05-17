using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Fattoria
{
  class Dog : Animal, IDomesticAnimal 
  {
        public static int dogCount=0;            //esiste sempre anche snza istanziare un cane 
    public Dog()
    {
            dogCount++;
      Debug.WriteLine("Dog cunstroctor invoked");
      LegsNumber = 4;
      AnimalFamily = Family.Mammals;
      Name = "Cane";
    }

    public void Talk()
    {
      Console.WriteLine("BAU!");
    }

        public override void Breath()
 
    {
      Console.WriteLine(Name + " bau-bau-eggiando!");
    }

    /* implematazione dei metodi delle interfacce */
    public void Company()
        {
            Console.WriteLine("Scodinzola");
        }
    public void Play()
        {
            Console.WriteLine("BAU BAU !");
        } 




    public override string ToString()
    {
      return Name;
    }
        ~Dog()
        {
            dogCount--;
            Debug.WriteLine("Dog destructor invoked");
        }
    }
}
