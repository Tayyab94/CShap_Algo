using System;
using System.Collections.Generic;

namespace lenear
{
    public class Class1
    {

        //Through lenear search we just find the  index of that perticuler values
        public static int LenearSearch(int []a, int s)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == s)
                    return i;
            }
            return -1;
        }

            
        public static void BuiltIn()
        {
            List<string> name = new List<string>();
            name.Add("Ali");
            name.Add("Umser");

            Console.WriteLine(name.AsReadOnly());
          
            showDAta(name);

            Console.ReadKey();
        }



        public static void showDAta(List<string> l)
        {
            Console.WriteLine("Data contain the list")
                ;


            foreach (string item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
