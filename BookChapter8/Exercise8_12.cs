using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter8
{
    class Exercise8_12
    {
        public static void Main()
        {
            int[] arr = new int[5];
            int num, counter = 0;
            bool duplicate = false;

            for(int i = 0;i < 5; i++)
            {
                duplicate = false;
                Console.Write("Please enter number {0}: ", i + 1);
                num = Convert.ToInt32(Console.ReadLine());

                for(int j = 0; j < i; j++)
                {
                    if (num == arr[j])                    
                        duplicate = true;
                }

                if (!duplicate)
                {
                    arr[counter] = num;
                    counter++;
                }
                    
            }

            for (int i = 0; i < counter; i++)
                Console.WriteLine(arr[i]);


        }


    }
}
