using System;

namespace Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Verilmish metnde sol terefden saydiqda {a},{b},{c}
            //simollarindan hansi birinci gelir?

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Cumle daxil edin: ");
            Console.ForegroundColor = ConsoleColor.White;
            string txt = Console.ReadLine();


            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'a')
                {
                    Console.WriteLine("a birinci ");
                    break;  
                }
                else if (txt[i] == 'b')
                {
                    Console.WriteLine("b birinci geldi");
                    break;
                }
                else if(txt[i] == 'c') 
                {
                    Console.WriteLine("c birinci geldi");
                    break;
                }
                else
                {
                    Console.WriteLine("hec biri birinci gelmir");
                    break;
                }
            }



        }
    }
}
