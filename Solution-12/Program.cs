using System;

namespace Solution_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12) Verilmish metindeen ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et. */

            Console.Write("Metn daxil edin : ");
            string txt = Console.ReadLine();

            Console.Write("Char daxil : ");
            char a = (char)Console.Read();

            int first = txt.IndexOf(a);
            int last = txt.LastIndexOf(a);

            int len = txt.Length;

            

            for (int i = 0; i < len; i++)
            {


                if (txt[i] == a)
                {

                    if (i != first && i !=last)
                    {
                        txt =txt.Remove(i,1);
                        len = len - 1;   //textin olcusu azalir deye 
                        last = last - 1;   // hemise sola gelir
                    }

                }
                
            }



            Console.WriteLine(txt);
           
        }


    }
}
