using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Operations.ParserOfLength();
            double[] Array = new double[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = Operations.GetElements();
            }
            Operations.Mult(Array);
            Operations.Sum1(Array);
            Operations.Sum2(Array);
            Operations.MULT(Array);
            Console.ReadKey();
        }
    }
}
