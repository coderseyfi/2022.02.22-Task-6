using System;

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi { a}
            //simvoludurmu?

            string txt = "Salam men Microsoft sirketinde web developer kimi fealiyyet gosterirem";
            bool check = true;
            for (int i = 0; i < txt.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (txt[i] != 'a')
                    {
                        
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                        break;
                    }
                } 
            }

            Console.WriteLine(check);

        }
    }
}
