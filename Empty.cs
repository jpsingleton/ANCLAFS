using System;

namespace Locking
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Task.Delay(100);
            Console.WriteLine("C# 7.1!");
            Console.ReadKey(true);
        }
    }
}
