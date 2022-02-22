using System;

namespace Solution_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8) Verilmish metnde ilk qabagima cixan { a}
            //simvolundan sonra gelen simvolu 10 defe dalbadal cap et.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cumle daxil edin: ");
            Console.ForegroundColor = ConsoleColor.White;
            string txt = Console.ReadLine();
            int len = txt.Length;

            bool check = true;

            for (int i = 0; i < len; i++)
            {
                if (txt[i] == 'a')
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(txt[i + 1]);
                    }
                }
            }

            Console.WriteLine(check);
        }
    }
}
