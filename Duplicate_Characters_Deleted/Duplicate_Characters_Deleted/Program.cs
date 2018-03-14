using System;

namespace Duplicate_Characters_Deleted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Removal instance = new Removal();
            instance.RemoveDuplicates("Warner Robbins");
            instance.RemoveDuplicates("What a lucky duck");
            Console.ReadLine();
        }
    }
}
