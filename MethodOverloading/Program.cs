using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 10, false));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool total)
        {
            int sum = Add(num1, num2);
            if (total)
            {
                if (sum == 1)
                {
                    return sum.ToString() + " dollar";
                }
                else
                {
                    return sum.ToString() + " dollars";
                }
            }
            else
            {
                return sum.ToString();
            }   
        }
    }
}
