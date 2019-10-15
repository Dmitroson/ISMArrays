using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Operations.ParserOfLength();
            double[] Array = new double[N];
            for(int i = 0; i < N; i++)
            {
               Array[i] = Operations.GetElements();
            }
          
            Operations.Sum(Array);
            Operations.Maximal(Array);
            Operations.IndexOfMaximal(Array);
            Operations.MaximalAbs(Array);
            Operations.SumOfIndex(Array);
            Operations.NumberOfIntegers(Array);
            Console.ReadKey();
        }
    }
}
