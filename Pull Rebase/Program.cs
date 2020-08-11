using System;

namespace Pull_Rebase
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameGenerator = new NameGenerator();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} + {nameGenerator.NewName()}");
            }
        }
    }
}