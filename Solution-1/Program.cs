using System;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Verilmish metnde {a}
            //simvolun sayi {b}
            //simvolun sayinda nece defe coxdur ?

            string text = "Salam bildiyimiz kimi Baki Azerbaycanin paytaxtidir";
            double countA = 0, countB = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    countA++;
                }
                else if (text[i] == 'b')
                {
                    countB++;
                }
            }
            Console.WriteLine(countA);
            Console.WriteLine(countB);

            double result;
            result = countA / countB;
            Console.WriteLine($"a simvolu b den nece defe coxdur : {result} ");


        }
    }
}
