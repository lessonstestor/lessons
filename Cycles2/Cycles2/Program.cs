using System;

namespace Cycles2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Используем for так как знаем конечное значение цикла
             (while используем если неуверенны, когда конкретно должен завершиться цикл)
             */
            for (int i = 0; i <= 98; i++)
            {
                if (i==0)
                {
                    continue;
                }
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
