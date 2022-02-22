using System;

namespace Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Verilmish metnde sol terefden ilk rast gelinen { a}
            //simvolunun yeri tek ededdi yoxsa cut ?

            string txt = "Salam bu gun 4 cu meselenin helline baxiriq";

            for (int i = 0; i < txt.Length; i++)
            {
                if (i %2 ==0 && txt[i] =='a')
                {
                    Console.WriteLine("Cut yerdedir");
                    break;
                }
                else if (i % 2 ==1 && txt[i] == 'a')
                {
                Console.WriteLine("tek yerdedir");
                    break;
                }
            }
        }
    }
}
