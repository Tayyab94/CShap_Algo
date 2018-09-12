using System;

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
    }
}
