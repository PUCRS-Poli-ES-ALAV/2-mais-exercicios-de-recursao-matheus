using System;

namespace ExerciciosRecursao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de Recursão");

            // System.Console.WriteLine(fatorial(5));
            // System.Console.WriteLine(fibonacci(5));
            // System.Console.WriteLine(somaAte0(5));
            // System.Console.WriteLine(somaJAteK(5, 9));
            // System.Console.WriteLine(isPal("arara"));
            // System.Console.WriteLine(convBase2(16));
            // System.Console.WriteLine(somaArray(new List<int>{5,6,7,8,9,10}));
            // System.Console.WriteLine(findBiggest(new List<int>{1,4,5,6,9}));
            // System.Console.WriteLine(findSubStr("abacaxi", "cax"));
            // System.Console.WriteLine(nroDigit(333));

        }

        public static int fatorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "O fatorial não é definido para números negativos.");
            }
            if (n == 1) return n;
            return n * fatorial(n - 1);
        }

        public static int somaAte0(int n)
        {
            if (n == 0) return 0;

            if (n < 0) return n + somaAte0(n + 1);

            return n + somaAte0(n - 1);
        }

        public static int fibonacci(int n)
        {
            if (n == 1) return 1;
            if (n < 1) return 0;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        public static int somaJAteK(int j, int k)
        {
            if (j > k)
            {
                return k + somaJAteK(j, k + 1);
            }

            if (j == k) return j;

            return j + somaJAteK(j + 1, k);
        }

        public static bool isPal(String s)
        {
            if (s.Length == 0 || s.Length == 1) return true;

            string novaString = s.Substring(1, s.Length - 2);
            if (s[0] == s[s.Length - 1]) return isPal(novaString);
            return false;
        }

        public static string convBase2(int n)
        {
            if (n == 1) return "1";

            if (n % 2 == 0) return convBase2(n / 2) + "0";

            return convBase2(n / 2) + "1";
        }

        public static int somaArray(List<int> ints)
        {
            if (ints.Count == 1) return ints[0];
            ints[0] = ints[0] + ints[1];
            ints.RemoveAt(1);
            return 0 + somaArray(ints);
        }

        public static int findBiggest(List<int> array)
        {
            if (array.Count == 1)
            {
                return array[0];
            }

            if (array[1] > array[0])
            {
                array[0] = array[1];
                array.RemoveAt(1);
                return 0 + findBiggest(array);
            }
            else
            {
                array.RemoveAt(1);
                return 0 + findBiggest(array);
            }
        }

        public static bool findSubStr(string str, string match)
        {
            if (str.Length < match.Length) return false;

            if (str.StartsWith(match)) return true;

            return findSubStr(str.Substring(1), match);
        }

        public static int nroDigit(int n)
        {
            if (n < 10 && n > 0) return 1;

            return 1 + nroDigit(n / 10);
        }

        
    }
}
