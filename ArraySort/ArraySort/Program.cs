using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,12,45,87,63,2,56,8,5,3,6,0 };
            Array.Sort(arr,new Mycomparison());
        
            foreach (int a in arr)
                Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
class Mycomparison : IComparer<int>
{
    public int Compare(int x,int y)
    {
        if(x>y)
        return -1;
        else
        {
            if (y > x)
                return 1;
            else
                return 0;
        }
    }
}