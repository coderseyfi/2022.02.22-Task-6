using System;

namespace Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metn daxil edin : ");
            string txt = Console.ReadLine();
            

            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsDigit(txt[i]))
                {
                    txt = txt.Replace(txt[i].ToString(), "");
                }


            }


            Console.WriteLine(txt);
        }
    }
}
