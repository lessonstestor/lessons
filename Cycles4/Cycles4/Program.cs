using System;

namespace Cycles4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPassword = "2281448", successUserPasword;
            int userAttemps = 3;

            Console.WriteLine("Hello its a secret panel type your password: ");
            while (userAttemps-- > 0)
            {
                successUserPasword = Console.ReadLine();
                    
                if (userPassword == successUserPasword)
                {
                    Console.WriteLine("Hello from Dark_Club");
                }
                else
                {
                    Console.WriteLine("Try again please. Your attemps: " + userAttemps);
                }
            }

        }
    }
}
