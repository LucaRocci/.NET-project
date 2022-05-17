using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttoRegine
{
   
        class Program
        {
            const int Boardsize = 8;
            const int MaxQueen = 8;

        static int[,] Offset = new int[8, 2]
        {
            {2, 1},
            {1, 2},
            {-1,2},
            {-2,1 },
            {-2,-1 },
            {-1,-2 },
            {1,-2 },
            {2,-1 }
        };

        struct Position      // si comporta come value type 
            {
                public int row;
                public int col;
            }

            static void Main(string[] args)
            {
                int[,] Board = new int[Boardsize, Boardsize];

                Position InitialPosition;
                InitialPosition.row = 0;
                InitialPosition.col = 0;

                Position CurrentPosition = InitialPosition;    // 

                int DoneMoves = 0;         //mosse fatte 
                                           // int TriedMoves = 0;
                DateTime dtStart = DateTime.Now;
                //TODO: elaborazione
                
            //da cambiare
                MarkMove(Board, CurrentPosition, ref DoneMoves);                 
                MoveHorse(Board, CurrentPosition, DoneMoves);

                DateTime dtFinish = DateTime.Now;                                 //tempo di esecuzione 
                Console.WriteLine("tempo impiegato: " + dtFinish.Subtract(dtStart).ToString());

                ShowBoard(Board);
                Console.ReadLine();
            }

            static void ShowBoard(int[,] Board)       //gia fatta
            {
                //Console.Write("  ");
                for (int r = 0; r < Boardsize; r++)
                {
                    Console.Write("");
                    Console.Write("\n");
                    for (int c = 0; c < Boardsize; c++)
                    {

                        if (Board[r, c] == 0)
                            Console.Write(" ");
                        else
                            Console.Write(" | {0:D2} | ", Board[r, c]);
                    }
                    Console.WriteLine();    //per fare a capo
                    Console.WriteLine();
                }
            }


            static bool MoveHorse(int[,] Board, Position CurrentPosition, int DoneMoves)
            {
                if (DoneMoves == Boardsize * Boardsize)
                    return true;

                for (int i = 0; i < 8; i++)
                {
                    Position NextPosition = CurrentPosition;
                    NextPosition.col += Offset[i, 0];          //
                    NextPosition.row += Offset[i, 1];

                    if (IsValid(Board, NextPosition))
                    {
                        MarkMove(Board, NextPosition, ref DoneMoves);     //si scatena la ricorsione 
                        if (MoveHorse(Board, NextPosition, DoneMoves))

                            return true;

                        UnMarkMove(Board, NextPosition, ref DoneMoves);

                    }

                }
                return false;
            }

            static bool IsValid(int[,] Board, Position ProposedPosition)   //da cambiare aggiungere controllo righe colonne e diagonale
            {                             //fuori da scacchiera 
            if (MaxQueen < 8)
            {
                if (ProposedPosition.row < 0 || ProposedPosition.row >= Boardsize || ProposedPosition.col < 0 || ProposedPosition.col >= Boardsize)
                    return false;
                //casella già occupata
                if (Board[ProposedPosition.row, ProposedPosition.col] != 0)
                    return false;

                else
                    return true;
            }
            else
                return false;
            }

        static void MarkMove(int[,] Board, Position MovePosition, ref int DoneMoves)
            {
                DoneMoves++;
                Board[MovePosition.row, MovePosition.col] = DoneMoves;  // il numero di mosse fatte mi marchia la casella in cui sono stato
            }
            static void UnMarkMove(int[,] Board, Position MovePosition, ref int DoneMoves)
            {
                DoneMoves--;
                Board[MovePosition.row, MovePosition.col] = 0;  // torno indietro e la casella torna marchiata a 0
            }


        }
    }


