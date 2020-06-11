using System;

namespace Cycles5Boss
{
    class Program
    {
        static void Main(string[] args)
        {
            float knightHealth = 250, knightArmor = 210, knightRasengan, knightChidori, knightShadowClone, knightEdoTensei;
            float bossHealth = 300, bossArmor = 200, bossAtack, bossRegenHealth;
            int knightChakra = 0;
            string commandSpell;

            Random randPower = new Random();
            knightRasengan = randPower.Next(20, 40);
            knightChidori = randPower.Next(20, 70);
            knightShadowClone = randPower.Next(20, 40);
            knightEdoTensei = randPower.Next(70, 100);
            bossAtack = randPower.Next(10, 20);
            bossRegenHealth = randPower.Next(5, 10);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  *  Knight War Game  *  ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вы небогатый рыцарь. Много здоровья, прочная броня. Также у вас в арсенале есть заклинания");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1 -Ушатать Расенганом (-10 здровья и удар по боссу в размере " + knightRasengan + ")\n" +
                              "2 -Теневое Клонирование (позволяет уйти от соперника и восстановить " + knightShadowClone + "HP)\n" +
                              "3 -Использовать Чидори (урон составляет " + knightChidori + " ВНИМАНИЕ, использовать только после Теневого Клонирования)\n" +
                              "4 -Эдо Тэнсэй (призывает духов общий урон по боссу" + knightEdoTensei + " однако отнимает 60HP)");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("ВНИМАНИЕ вы встретили БОССА");
            Console.ResetColor();
            Console.WriteLine("Здоровье " + bossHealth + " | Броня " + bossArmor + " (Босс имеет возможность восстанавливать здоровье)");
            Console.WriteLine(" ! Используйте цифры указанные выше для атаки ! ");

            while (knightHealth > 0 || bossHealth > 0)
            {
                commandSpell = Console.ReadLine();
                switch (commandSpell)
                {
                    default:
                        Console.WriteLine("Вы пропускаете удар теперь ваше здоровье равно " + (knightHealth -= bossAtack) + " ! Используйте скилы ! ");
                        break;
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Вы использовали Расенган");
                        knightHealth -= (10 + bossAtack) / 100 * knightArmor;
                        bossHealth -= knightRasengan / 100 * bossArmor;
                        bossHealth += bossRegenHealth;
                        Console.WriteLine("Ваше здоровье " + knightHealth + " (чакра - " + knightChakra + ") | " + "Здоровье босса " + bossHealth);
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Вы использовали Теневое Клонирование");
                        knightHealth -= bossAtack / 100 * knightArmor;
                        knightHealth += knightShadowClone;
                        bossHealth -= knightRasengan / 100 * bossArmor;
                        bossHealth += bossRegenHealth;
                        knightChakra++;
                        Console.WriteLine("Ваше здоровье " + knightHealth + " (чакра - " + knightChakra + ") | " + "Здоровье босса " + bossHealth);
                        Console.ResetColor();
                        break;
                    case "3":
                        if (knightChakra > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы использовали Чидори");
                            knightHealth -= (bossAtack / 100 * knightArmor);
                            bossHealth -= knightChidori / 100 * bossArmor;
                            bossHealth += bossRegenHealth;
                            knightChakra--;
                            Console.WriteLine("Ваше здоровье " + knightHealth + " (чакра - " + knightChakra + ") | " + "Здоровье босса " + bossHealth);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Вы еще не использовали Теневое Клонирование чакра не востановленна босс наносит вам удар\n Ваше здоровье " + (knightHealth -= bossAtack));                       
                        }
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вы использовали Эдо Тенсей");
                        knightHealth -= (bossAtack + 60) / 100 * knightArmor;
                        bossHealth -= knightEdoTensei / 100 * bossArmor;
                        bossHealth += bossRegenHealth;
                        Console.WriteLine("Ваше здоровье " + knightHealth + " (чакра - " + knightChakra + ") | " + "Здоровье босса " + bossHealth);
                        Console.ResetColor();
                        break;
                }
                if (knightHealth <= 0 && bossHealth > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ваш герой пал");
                    Console.ResetColor();
                }
                else if(bossHealth <= 0 && knightHealth > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ПОБЕДА !");
                    Console.ResetColor();
                }
                else if (bossHealth <= 0 && knightHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Boss и Knight пали одновременно. Ничья");
                    Console.ResetColor();
                }
            }
        }
    }
}
