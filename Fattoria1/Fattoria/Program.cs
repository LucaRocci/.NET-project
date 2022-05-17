using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("lessie",Animal.Family.Mammifero,4);

            a1.Nickname = "Pippo";
            a1.Codice = 123334343434234;

            //a1.LegsNumber = 4;
            //a1.Name = "Lessie"; 
            //a1.AnimalFamily = Animal.Family.Mammifero;   // per vedere fai ctrl spazio
            a1.Move();

            Animal a2 = new Animal("Snoopy", Animal.Family.Mammifero, 4);

            a2.Nickname = "Giacomo";
            a2.Codice = 23;
            //a2.LegsNumber = 4;
            //a2.Name = "Snoopy";
            //a2.AnimalFamily= Animal.Family.Uccello;   // per vedere fai ctrl spazio
            a2.Move();

            Animal a3 = new Animal("Pizza", Animal.Family.Anfibio, 0);  // con il nostro costruttore

            a3.Nickname = "Simone";
            //a3.LegsNumber = 0;
            //a3.Name = "PonzioPilato";
            //a3.AnimalFamily=Animal.Family.Anfibio;   // per vedere fai ctrl spazio
            a3.Move();

            Animal[] a = new Animal[3];   //dichiaro un array di 3 animali con 3 puntatori a 3 istanze di Animal 


            Console.WriteLine(a1.GetLegsNumber() + " " + a2.GetLegsNumber() + " " + a3.GetLegsNumber());   //richiamando il metodo ()

            Console.WriteLine(a1.Legs + " " + a2.Legs + " " + a3.Legs);   //leggere le proprietà 

            Console.WriteLine(a1.Nickname + "  " + a2.Nickname + "  "+a3.Nickname);

            Console.WriteLine(a1.Codice+"  "+a2.Codice);
            //necessito fare a[0] =new Animal(); 
            //necessito fare a[1] =new Animal();
            //necessito fare a[2] =new Animal();




            //Console.WriteLine(a1.Name);
            //Console.WriteLine(a1.LegsNumber);
            //Console.WriteLine(a1.AnimalFamily);
            Console.ReadLine();
        }
    }
}
