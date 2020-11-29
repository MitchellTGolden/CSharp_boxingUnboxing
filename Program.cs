using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> mix = new List<object>();
            mix.Add(7);
            mix.Add(28);
            mix.Add(-1);
            mix.Add(true);
            mix.Add("chair");
            int sum = 0;
            foreach (var item in mix)
            {
                if (item is int)
                {
                    Console.WriteLine($"{item} is int");
                    int num = (int)item;
                    sum += num;
                }
                if(item is bool){
                Console.WriteLine(item);
                }
                if(item is string){
                Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Sum of list: {sum}");
        }

    }
}
