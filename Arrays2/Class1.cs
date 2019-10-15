using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Operations
    {
        public static int ParserOfLength()
        {
            var s = Console.ReadLine();
            int N = 0;
            if (int.TryParse(s, out N) == false || int.Parse(s) < 0)
            {
                Console.WriteLine("Repeat please: ");
                s = Console.ReadLine();
            }
            return N;
        }
        public static double GetElements()
        {
            var s = Console.ReadLine();
            double N = 0;
            if (double.TryParse(s, out N) == false)
            {
                Console.WriteLine("Repeat please: ");
                s = Console.ReadLine();
            }
            return N;
        }
        public static void Mult(double[] SomeArray)
        {
            double min = 1000000;
            int j = 0;
            for(int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] < min)
                {
                    min = SomeArray[i];
                    j = i;
                }
            }
            double mult = 1;
            if (j == SomeArray.Length - 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for(int i = j+1; i < SomeArray.Length; i++)
                {
                    mult *= SomeArray[i];
                }
            }
            Console.WriteLine($"Добуток елементів після мінімального: {mult}");
        }
        public static void Sum1(double[] SomeArray)
        {
            double sum = 0;
            int j1 = 0, j2 = 0;
            for(int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] < 0)
                {
                    j1 = i;
                    break;
                }
            }
            int k = 0;
            for (int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] > 0)
                {
                    k++;
                    if (k == 2)
                    {
                        j2 = i;
                        break;
                    }
                }
            }
            Swap(j1, j2);
            for(int i = j1 + 1; i < j2; i++)
            {
                sum += SomeArray[i];
            }
            Console.WriteLine($"Сума елементів массиву між першим від'ємним та другим додатнім: {sum}");
        }
        public static void Swap(int A, int B)
        {
            int temp = 0;
            if (A > B)
            {
                temp = B;
                B = A;
                A = temp;
            }
        }
        public static void Sum2(double[] SomeArray)
        {
            double sum = 0;
            int j1 = 0, j2 = 0;
            for(int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] == 0)
                {
                    j1 = i;
                    break;
                }
            }
            for(int i = SomeArray.Length - 1; i >= 0; i--)
            {
                if (SomeArray[i] == 0)
                {
                    j2 = i;
                    break;
                }
            }
            for(int i = j1 + 1; i < j2; i++)
            {
                sum += SomeArray[i];
            }
            Console.WriteLine($"Сума елементів між першим нульовим та останнім нульовим: {sum}");
        }
        public static void MULT(double[] SomeArray)
        {
            double mult = 1;
            double min = 1000000, max = -1000000;
            int MinAbs = 0, MaxAbs = 0;
            for(int i = 0; i < SomeArray.Length; i++)
            {
                if (Math.Abs(SomeArray[i]) < min)
                {
                    min = Math.Abs(SomeArray[i]);
                    MinAbs = i;
                }
            }
            for (int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] < max)
                {
                    max = Math.Abs(SomeArray[i]);
                    MaxAbs = i;
                }
            }
            Swap(MinAbs, MaxAbs);
            if (MinAbs == MaxAbs)
            {
                Console.WriteLine("Добуток елементів массиву між мінімальним та максимальним за модулем: 0");
            }
            else
            {
                for(int i = MinAbs + 1; i < MaxAbs; i++)
                {
                    mult *= SomeArray[i];
                }
                Console.WriteLine($"Добуток елементів массиву між мінімальним та максимальним за модулем: {mult}");
            }
        }
    }
}