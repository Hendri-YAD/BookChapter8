using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter8
{
    class Exercise8_10
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of employees: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] counter = new int[9];
            double salary = 0;
            double gross = 0;

            for(int i = 0; i < length; i++)
            {
                Console.Write("Please enter the gross sales amount of employee {0}: $", i + 1);
                gross = Convert.ToDouble(Console.ReadLine());
                salary = 200 + 0.09 * gross;
                SalaryRange(counter, salary);
            }

            PrintArray(counter);            
        }

        public static void SalaryRange(int[] count, double sal)
        {
            if(sal >= 200 && sal <= 299)
                count[0]++;
            else if (sal > 299 && sal <= 399)
                count[1]++;
            else if (sal > 399 && sal <= 499)
                count[2]++;
            else if (sal > 499 && sal <= 599)
                count[3]++;
            else if (sal > 599 && sal <= 699)
                count[4]++;
            else if (sal > 699 && sal <= 799)
                count[5]++;
            else if (sal > 799 && sal <= 899)
                count[6]++;
            else if (sal > 899 && sal <= 999)
                count[7]++;
            else
                count[8]++;           
        }

        public static void PrintArray(int[] counter)
        {
            Console.WriteLine("$200-299\t {0}", counter[0]);
            Console.WriteLine("$300-399\t {0}", counter[1]);
            Console.WriteLine("$400-499\t {0}", counter[2]);
            Console.WriteLine("$500-599\t {0}", counter[3]);
            Console.WriteLine("$600-699\t {0}", counter[4]);
            Console.WriteLine("$700-799\t {0}", counter[5]);
            Console.WriteLine("$800-899\t {0}", counter[6]);
            Console.WriteLine("$900-999\t {0}", counter[7]);
            Console.WriteLine("$1000 and over\t {0}", counter[8]);            
        }


    }
}
