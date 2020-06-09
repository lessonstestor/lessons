using System;

namespace Variables6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userZodiac, userJob;
            int userAge;

            Console.Write("Ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш знак зодиака: ");
            userZodiac = Console.ReadLine();
            Console.Write("Ваше место работы: ");
            userJob = Console.ReadLine();
            Console.WriteLine($"Вас зовут {userName}, возраст {userAge}, вы {userZodiac} и ваше место работы {userJob}");
            Console.Read();
        }
    }
}
