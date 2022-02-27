using System;

namespace Solution_15
{
    class Program
    {
        static void Main(string[] args)
        {
              //            15)*Verilmish metinde ilk ve son simvol eynidirse,
            //ve metn daxilinde yanashi gelen { a}
            //            simvolu varsa,
            //ve metn daxilinde { b}
            //            simvolu yoxdursa
            //o zaman bu metnde butun { c}
            //            simvollari yox et ve
            //neticede alinan metn zerkalni olub olmadigini yoxla.


            string txt = Console.ReadLine().ToLower();
            char a = 'a';
            char b = 'b';
            char c = 'c';
            char first = txt.FirstOrDefault();
            char last = txt.LastOrDefault();
            bool check = false;
            

            for (int i = 0; i < txt.Length-2; i++)
            {
                if (first == last )
                {
                    if (txt[i]== a && txt[i+1]== a)
                    {
                        if (txt[i] !=b)
                        {
                            txt = txt.Replace(c.ToString(), "");
                           

                            check = true;
                        }
                    }
                }
            }


            if (check == true)
            {
                Console.WriteLine("metn zerkalnidi");
            }
            else
            {
                Console.WriteLine("metn o deyil");
            }

            
            Console.WriteLine(txt);
            Console.WriteLine(check);
            
            
            
        }
    }
}
