using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 1, 3, 2, 3, 5 };
            Console.WriteLine("{0}",FirstDuplicate(a));

        }

        private static int FirstDuplicate(int[] a)
        {
            ArrayList numList = new ArrayList();
            int num = -1;
            //num.Add(-1);
            //int[] b = new int[] { -1 };
            foreach (int i in a)
            {
                
                if (numList.Contains(i))
                {
                    //num.Remove(-1);
                    num=i;
                    return num;
                 
                }
                else
                {
                     numList.Add(i);
                   

                }


            }
            return num;


        }
    }
}
