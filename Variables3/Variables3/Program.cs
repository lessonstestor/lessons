using System;

namespace Variables3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inRow = 3, userImages = 52, maxRow;
            maxRow = userImages / inRow;

            Console.WriteLine("Количество полностью заполненных рядов = " + maxRow);
            Console.Read();
        }
    }
}
