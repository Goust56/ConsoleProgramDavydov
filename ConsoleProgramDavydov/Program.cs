using System;
namespace ConsoleProgramDavydov
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Написать программный модуль для подсчета количества символов до точки с запятой и после нее";
            int before = text.IndexOf(';');
            int after = text.Length - before - 1;
            Console.WriteLine($"до {before}, после {after}");
            Console.ReadKey();
        }
    }
}
