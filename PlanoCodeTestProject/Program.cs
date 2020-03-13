using System;

namespace PlanoCodeTestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number:");

            int num = Convert.ToInt32(Console.ReadLine());

            if (CheckPalindrome(num))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static bool CheckPalindrome(int num)
        {
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length - 1; i++)
            {

                if (numStr[i] == numStr[i + 1])
                    return true;
            }
            return false;
        }

    }
    }

