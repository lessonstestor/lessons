using System;

namespace Cycles3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userSymbol;
            Console.WriteLine("Please write your name...");
            userName = Console.ReadLine();
            Console.WriteLine("Your name: " + userName);

            Console.WriteLine("Please write your symbol...");
            userSymbol = Console.ReadLine();
            Console.WriteLine("Your symbol: " + userSymbol);

            Console.WriteLine("Your result:");
            for (int i = 0; i < userName.Length+2; i++)
            {
                Console.Write(userSymbol);
            }
            Console.WriteLine();
            Console.WriteLine(userSymbol + userName + userSymbol);
            for (int i = 0; i < userName.Length+2; i++)
            {
                Console.Write(userSymbol);
            }
            Console.Read();
        }
    }
}
