using System;

namespace Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}
            //-ye beraberdir.

            string txt = "Bugun bakinin  babek prospektinde qeza bas verib";
            
            int counter = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                if (i%2 == 1)
                {
                    if (txt[i] == 'b' )
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
