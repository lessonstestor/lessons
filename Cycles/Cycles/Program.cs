using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            float userBalanceRub = 300, userBalanceUah = 150, userBalanceEur = 200, countForUserEuroConvert, afterConvertBalance;
            float courseRubToday = 25.6f, courseUahToday = 30.4f;

            int selectUserBalance;

            Console.WriteLine("Меню конвертера:");
            Console.WriteLine("Введите 1 -  для перевода евро в рубли");
            Console.WriteLine("Введите 2 -  для перевода евро в гривны");

            selectUserBalance = Convert.ToInt32(Console.ReadLine());

            switch (selectUserBalance)
            {
                case 1:
                    Console.WriteLine("Вы выбрали конвертацию с евро в рубли ваш баланс: " + userBalanceRub + " рублей и " + userBalanceEur + " евро" );
                    Console.Write("Введите сумму евро для конвертации: ");
                    countForUserEuroConvert = Convert.ToSingle(Console.ReadLine()); // можно сделать проверку через if для проверки баланса
                    afterConvertBalance = countForUserEuroConvert * courseRubToday; 
                    Console.WriteLine("Вы получили " + afterConvertBalance + " рублей");
                    Console.WriteLine("Теперь на вашем балансе " + (userBalanceRub + afterConvertBalance) + " рублей и " + (userBalanceEur - countForUserEuroConvert) + " евро");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали конвертацию с евро в гривны ваш баланс: " + userBalanceUah + " гривен и " + userBalanceEur + " евро");
                    Console.Write("Введите сумму евро для конвертации: ");
                    countForUserEuroConvert = Convert.ToSingle(Console.ReadLine()); // можно сделать проверку через if для проверки баланса
                    afterConvertBalance = countForUserEuroConvert * courseUahToday; 
                    Console.WriteLine("Вы получили " + afterConvertBalance + " гривен");
                    Console.WriteLine("Теперь на вашем балансе " + (userBalanceUah + afterConvertBalance) + " гривен и " + (userBalanceEur - countForUserEuroConvert) + " евро");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Не надо ломать аппарат");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
