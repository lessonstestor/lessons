using System;

namespace Variables4
{
    class Program
    {
        static void Main(string[] args)
        {
            float gold, crystalPrice = 10, userCrystals, convertGold, userGold; 

            Console.Write( "Введите ваше количество золота: " );

            gold = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine( "Цена кристалов " + crystalPrice );
            Console.Write("Сумма золота для конвертации: ");

            convertGold = Convert.ToSingle(Console.ReadLine());
            userCrystals = crystalPrice / convertGold;
            userGold = gold - convertGold;

            Console.WriteLine( "В случае обмена количество криcталов равно " + userCrystals + " - остаток золота равен " + userGold);
            Console.Read();
        }
    }
}
