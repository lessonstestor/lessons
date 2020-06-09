using System;

namespace Variables5
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForOnePersonReseption = 10, grannies, hoursCounter, minutesCounter;

            Console.Write("Введите кол-во старушек: ");

            grannies = Convert.ToInt32(Console.ReadLine());

            hoursCounter = grannies * timeForOnePersonReseption / 60;
            minutesCounter = grannies * timeForOnePersonReseption - 60 * hoursCounter;

            Console.WriteLine( "Вы должны отстоять в очереди: " + hoursCounter + " часа и " + minutesCounter + " минут" );
            Console.Read();
        }
    }
}
