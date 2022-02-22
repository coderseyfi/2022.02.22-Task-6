using System;

namespace Solution_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //7) Verilmish metnde { a}
            //simvolu { b} simvolundan qabaq ve oda { c} simvolundan qabaq gelirmi ?

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cumle daxil edin: ");
            Console.ForegroundColor = ConsoleColor.White;
            string txt = Console.ReadLine();
            bool check = true;

            int counter = 0;
            if (txt.Length>2)
            {
                for (int i = 0; i < txt.Length-2; i++)
                {

                    if (txt[i] == 'a')
                    {
                        counter++;
                        if (txt[i+1] == 'b'&& counter==1)
                        {
                            if (txt[i + 2] == 'c' && counter == 2)
                            {
                                check = true;
                                break;
                            }
                        }
                    }



                }
            }


            Console.WriteLine(check);


        }
    }
}
