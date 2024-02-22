using System;

namespace Notenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Notenrechner");
            double note;
            do
            {
                Console.WriteLine("Geben Sie Ihre Note ein (zwischen 1 und 6): ");
            } 
            while (!double.TryParse(Console.ReadLine(), out note) || note < 1 || note > 6);
            Console.WriteLine($"Eingegebene Note: {note}");
        }
    }
}
