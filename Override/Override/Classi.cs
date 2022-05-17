using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class A
    {
        public virtual void M()
        { 
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void M()
        {
            Console.WriteLine("B");
        }
    }

    class C : B
    {
    // "new virtual" interrompe la catena di override
    // Siamo in presenza di "hiding": questo metodo M() nasconde il metodo M() della classe B 
    new public virtual void M()     
        {
            Console.WriteLine("C");
        }
    }

    class D : C
    {
        public override void M()
        {
            Console.WriteLine("D");
        }
    }
}
