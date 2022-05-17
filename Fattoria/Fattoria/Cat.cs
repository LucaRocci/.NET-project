using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    class Cat : Animal, IDomesticAnimal
    {
        /* implematazione dei metodi delle interfacce */
        public void Company()
        {
            Console.WriteLine("Fusa...");
        }
        public void Play()
        {
            Console.WriteLine("MIAO MIAO!");
        }

        public override void Breath()
        {
            Console.WriteLine("ZZzzzzzzz!");
        }


    }
}
