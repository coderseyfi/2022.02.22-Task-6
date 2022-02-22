using System;

namespace Solution_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.

            Console.Write("Enter the text : ");
            string a = Console.ReadLine();
            string b = "";
            int counter = 0;


            for (int i = 0; i < a.Length; i++)
            {

                if (i % 2 == 0)
                {
                    b = b + a[i].ToString().ToLower();
                }

                if (i % 2 == 1)
                {
                    b = b + a[i].ToString().ToUpper();
                }



               

            }

            Console.WriteLine(b);
          

        }
    }
}

