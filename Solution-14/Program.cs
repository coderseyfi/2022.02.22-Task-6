
using System;

namespace Solution_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et.

            //salame
            //AaAaEe

            Console.WriteLine("metn daxil edin : ");
            string txt = Console.ReadLine();
            string txt1 = "";

            for (int i = 0; i < txt.Length; i++)
            {

                if (i %2 == 1 && i<txt.Length)
                {
                    txt1 = txt1 + txt[i+1].ToString().ToUpper();
                    continue;
                }
                txt1 = txt1 + txt[i];
            }
            Console.WriteLine(txt);
            Console.WriteLine(txt1);
        }
    }
}
