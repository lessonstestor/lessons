using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 38 * 17;
            int c = (31 - 5 * a) / b;
            Console.WriteLine(c);
            Console.Read();
            // Ответ будет равен 0 так как int не может принемать значения с плавающей запятой.
        }
    }
}
