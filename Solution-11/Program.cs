using System;

namespace Solution_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve
            eyni zamandan butun { b}
            simvollarinin qabagina { a}
            simvolunu yaz.*/

            Console.Write("metn daxil edin : ");
            string txt = Console.ReadLine();

            char a = 'a';
            char b = 'b';



            for (int i = 0; i < txt.Length; i++)
            {

                if (txt[i] == a)
                {
                    txt = txt.Insert(i, b.ToString());
                    i++;

                }
                else if (txt[i] == b)
                {
                    txt = txt.Insert(i, a.ToString());
                    i++;

                }



            }

            Console.WriteLine(txt);

        }
    }
}
