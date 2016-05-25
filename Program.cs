using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Queue<int> nums = new Queue<int>();
            for(int i = 0; i < 10; i++)
            {
                int num = rnd.Next(0, 1000);
                nums.Enqueue(num);
                Console.WriteLine(i.ToString() + " " + num);
            }
            Console.WriteLine();
            for(int i = 0; i < 10; i++)
            {
                int num = nums.Dequeue();
                Console.WriteLine(i.ToString() + " " + num);
            }
            Console.WriteLine("Press Enter to continue.....");
            Console.ReadLine();

        }
    }
}
