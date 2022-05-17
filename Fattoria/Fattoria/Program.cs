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
            //RedFish rf =new RedFish();
            //rf.Breath();
            //Console.WriteLine(rf.ToString());

            //Turkey t = new Turkey();
            //t.Talk();
            //t.Breath();
            //Dog d = new Dog();
            //Console.WriteLine(d.ToString());
            //Basset b = new Basset();
            //b.Name = "Ciccio";

            // b.Talk();
            //b.Breath();
            //Console.WriteLine(b.ToString());
            Console.WriteLine("Cani: " + Dog.dogCount);

            List<Animal> lista = new List<Animal>();

            Dog lassie = new Dog();
            Console.WriteLine("Cani: " + Dog.dogCount);
            lista.Add(lassie);
            RedFish pippo = new RedFish();
            lista.Add(pippo);
            Basset charlie = new Basset();
            lista.Add(charlie);
            Turkey piera = new Turkey();
            lista.Add(piera);


            //foreach(Animal a in lista)
            //    {
            //    a.Breath();
            //    Dog x = (a as Dog);     -> è interpretaile come Dog??
            //    if (x!=null) 
            //        x.Talk();
            //    if (a.GetType() == typeof(Dog))  //-> E un dog??
            //   {
            //    (a as Dog).Talk();
            //}
            Dog d1 = new Dog();
            Dog d2 = new Dog();
            Dog d3 = d1;
            Console.WriteLine("Cani: " + Dog.dogCount);
            Animal a1 = new Dog();
            Animal a2 = new Cat();
            (a1 as Dog).Talk();                      //sempre casting guardo ad a1  come Cane non come animale
            (a2 as IDomesticAnimal).Company();


           // GC.Collect();
            Console.ReadLine();
            d1 = null;
            d3 = null;
            d2.Play();
            charlie.Company();
            Console.WriteLine("Cani: " + Dog.dogCount);
            GC.Collect();
            Console.WriteLine("Cani: " + Dog.dogCount);

            Console.ReadLine();


            

    }
  }
}
