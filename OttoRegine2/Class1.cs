using System;

namespace OttoRegine2
{
  /// <summary>
  ///	Rompicapo delle OTTO REGINE
  /// </summary>
  class Class1
  {
    // Ci sono 8 regine, una per colonna
    // Nell'array, di ciascuna regina memorizzo in che riga viene piazzata
    static int[] queen = new int[8];

    static byte[] row = new byte[8];
    static byte[] dia = new byte[15];
    static byte[] rdia = new byte[15];

    static void Main(string[] args)
    {
      int i, j;
      if (muovi(0))     // se restrituisce true
      {
        for (i = 0; i < 8; i++)
        {
          for (j = 0; j < 8; j++)
            if (queen[i] == j)   //va da 0 a 7 '
              Console.Write("X ");
            else
              Console.Write("O ");
          Console.WriteLine();
        }
      }
      Console.ReadLine();
    }

    static bool muovi(int n)  // il nuemro della regina che sto piazzando 
    {
      int i;
      if (n == 8)     // posizionate tutte e 8 le regine
        return (true);
      for (i = 0; i < 8; i++)
        if (row[i] == 0 && dia[n + i] == 0 && rdia[n - i + 7] == 0)    // la metto solo se
        {
          setqueen(n, i);
          if (muovi(n + 1))  //passo all'altra regina se ho messo la 1° passo alla 2°
            return (true);
          removequeen(n, i);
        }
      return (false); // se ritorna false  torno indietro e ne rimuovo 1 
    }

    static void setqueen(int colonna, int riga)
    {
      queen[colonna] = riga;          //riceve coordinate regina 
      row[riga] = dia[colonna + riga] = rdia[7 + colonna - riga] = 255;  //setto come occupata riga diagionale e 2°diagonale
    }

    static void removequeen(int colonna, int riga)
    {
      queen[colonna] = row[riga] = dia[colonna + riga] = rdia[7 + colonna - riga] = 0;
    }
  }
}


// 8 cicli  annidati per non farlo ricorsivo //


