using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public class Animal
    {
        public string Name;
        public Family AnimalFamily;    // animalFamily avrà olo un numero di valori finiti
        private int LegsNumber;
        private string _Nickmane;
        private int _Codice;


        public long Codice
        {
            get
            {
                return _Codice;
            }
            set
            {
                string s = value.ToString();
                _Codice = int.Parse(s.Substring(0, s.Length>=3 ? 3 : s.Length));       //if inline 
            }


        }
        public string Nickname
        {
            get
            {
                return _Nickmane;
            }
            set
            {
                if(value.Length>3)
                    _Nickmane = value.Substring(0,3);
            
                else
                _Nickmane = value;
              //  throw new Exception("Nickname troppo Lungo");
            }
        }
        public int Legs     //questa è una proprietà   readonly
        {
            get
            {
                return LegsNumber;
            }
        }

        public int GetLegsNumber()    //questo è un metodo 
        {
            return LegsNumber;
        }


        public void Move()
        {
            Console.WriteLine(Name+"  Moving..");
        }


        //public Animal()            //esempio di overloading     costruttore vuoto 
        //{ }
  


        public Animal(string Name, Family AnimalFamily, int LegsNumber)
        {
            this.Name = Name;
            this.AnimalFamily = AnimalFamily;
            this.LegsNumber = LegsNumber;
        }
        
        public enum Family
        {
            Mammifero,
            Uccello,
            Rettile,
            Anfibio
        }
    }
}
