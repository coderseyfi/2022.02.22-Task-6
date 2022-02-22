using System;

namespace Solution_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) Verilmish metnde {a}
            //simvolunun sol terefden ve sag terefden indexleri eydidirmi?


            Console.Write("Enter textt : ");
            string txt = Console.ReadLine();
            Console.Write("\nEnter Char:");
            char a = (char)Console.Read(); 
            int len = txt.Length;

            bool check = false;
            int counter;

            for (int i = 0; i <= len / 2; i++)
            {
                counter = 0;
                for (int j = len - 1; j >= len / 2; j--)
                {
                   
                    if (i == counter && txt[i] == a && txt[j] == a)
                    {
                        check = true;
                    }
                    
                    counter++;
                }

            }

            Console.WriteLine(check);
        }
    }
}
