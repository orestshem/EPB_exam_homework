using System;

namespace EPB_test_DZ
{
    internal class Program
    {

        //через рекурсію
        public static int FactorialRecursion(int userNum)
        {
            if (userNum == 0)
            {
                return 1;
            }
            else
            {
                return userNum * FactorialRecursion(userNum - 1);
            }
        }

        //не через рекурсію
        public static int FactorialWithoutRecursion(int userNum)
        {
            int result = 1;
            for (int i = 1; i <= userNum; i++)
            {
                result *= i;
            }
            return result;
        }



        static void Main(string[] args)
        {
            //приклад роботи
            Console.WriteLine("Please, enter your integer number: ");
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine("With recursion: {0}", FactorialRecursion(userNum));
            Console.WriteLine("Without recursion: {0}", FactorialWithoutRecursion(userNum));
        }
    }
}