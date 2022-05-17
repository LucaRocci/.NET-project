using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace _24032022Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string op1;
                string op2;
                string oper;
                int o2;
                int o1;
                do
                {
                    Console.WriteLine("Primo operando: ");
                    op1 = Console.ReadLine();
                }
                while (!Information.IsNumeric(op1));
                o1 = int.Parse(op1);
                do
                {
                    Console.WriteLine("Secondo operando: ");
                    op2 = Console.ReadLine();
                } 
                while (!int.TryParse(op2, out o2));

                do
                {
                    Console.WriteLine("Operatore: +,-,*,/");
                    oper = Console.ReadLine();
                }
                while (!"+,-,*,/".Contains(oper) || oper.Length!=1); //(oper != "+" && oper != "/"  && oper !="-" && oper != "*" ) ;  (!("+,-,*,/".Contains(oper) && oper.Length==1))
                int ris;
                switch (oper)
                {
                    case "+":
                        ris = o1 + o2;
                        break;
                    case "-":
                        ris = o1 - o2;
                        break;
                    case "*":
                        ris = o1 * o2;
                        break;
                    case "/":
                        ris = o1 / o2;
                        break;
                    default:
                        ris = 0;
                        break;
                }
                Console.WriteLine("Risultato: " + ris.ToString());

            } while (Console.ReadLine() != "stop");
         
        }
    }
}
