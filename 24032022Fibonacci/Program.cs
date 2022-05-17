using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24032022Fibonacci
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Qunati numeri della sequenza vuoi stampare:? ");
            string s=Console.ReadLine();
            int quanti = int.Parse(s);       //   int quanti = int.Parse(Console.ReadLine());

            try            //
            {
               int[] r = SerieFibonacci(quanti);
              //  for (int i = 0; i < quanti; i++)
                //    Console.Write("{0} ", r[i]);
                foreach(int p in r)
                    Console.Write("{0} ", p);

            }
            catch(OverflowException over)          //funzione che cattura l'eccezione e si porta in una varialibe una serie di informazioni
            {
                Console.WriteLine("Serie troppo Lunga!!");
                Console.WriteLine(over.Message);       //
                Console.WriteLine(over.StackTrace);    //
            }
            catch(DivideByZeroException Div)
            {
                Console.WriteLine("Divisione per zero!!");
            }
            catch(Exception exG)
            {
                Console.WriteLine("Errore non previsto!");
            }
            finally   //codice eseguito a prescindere da try e catc,eseguito dopo il try e catch
            {
                Console.ReadLine();
            }
           
        }

     static int[] SerieFibonacci(int quanti)  //valore e riferimento come in C
        {
            int[] res = new int[quanti];
            int prec = 0;
            int init = 1;
            int somma;
            int ri = 0;
            res[ri++] = prec;    //  stessa cosa di res[0]
            res[ri++] = init;    // stessa cosa di res[1]

            // Console.Write("{0} {1} ",prec,init);    //Write no và a capo  {}--> fungono da segna-posto
            //   Console.Write(a.Tostring() +" " + );     altro modo di scrivere
            /*for(int i=2; i<quanti; i++)
            {
                somma = prec + init;
                prec = init;
                init=somma;
                Console.Write("{0} ", somma);
               */
            int i = 2;
            /*
            while (i < quanti)
            {
                somma = prec + init;
                prec = init;
                init = somma;
                Console.Write("{0} ", somma);
                i++;
            }
            */
            for(;i<quanti;)
            {
                somma = prec + init;
                prec = init;
                init = somma;
               // Console.Write("{0} ", somma);
                res[ri++] = somma;
                i++;
            }
            return res;
        }
     }
    }

