using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
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
        public static void Sum(double[] SomeArray)
        {
            double sum = 0;
            for (int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] < 0)
                {
                    sum += SomeArray[i];
                }
            }
            Console.WriteLine($"Сума від'ємних елементів: {sum}");
        }
        public static double Maximal(double[] SomeArray)
        {
            double Max = -1000000;
            for (int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] > Max)
                {
                    Max = SomeArray[i];
                }
            }
            Console.WriteLine($"Максимальний елемент: {Max}");
            return Max;
        }
        public static void IndexOfMaximal(double[] SomeArray)
        {
            double MaximalElement = -1000000;
            int index = 0;
            for (int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] > MaximalElement)
                {
                    MaximalElement = SomeArray[i];
                    index = i;
                }
            }
            Console.WriteLine($"Індекс максимального елемента массиву: {index}");
        }
        public static void MaximalAbs(double[] SomeArray)
        {
            double Max = -1000000;
            double MaxAbs = 0;
            for (int i = 0; i < SomeArray.Length; i++)
            {
                if (Math.Abs(SomeArray[i]) > Max)
                {
                    Max = Math.Abs(SomeArray[i]);
                    MaxAbs = SomeArray[i];
                }
            }
            Console.WriteLine($"Максимальний за модулем елемент: {MaxAbs}");
        }
        public static void SumOfIndex(double[] SomeArray)
        {
            int sum = 0;
            for(int i = 0; i < SomeArray.Length; i++)
            {
                if (SomeArray[i] > 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сума індексів додатніх елементів: {sum}");
        }
        
        public static void NumberOfIntegers(double[] SomeArray)
        {
            int Numbers = 0;
            for(int i = 0; i < SomeArray.Length; i++)
            {
                
                if (SomeArray[i]%1==0)
                {
                    Numbers = Numbers + 1;
                }
            }
            Console.WriteLine($"Кількість цілих чисел в массиві: {Numbers}");
        }
    }
}