using System;

namespace WannwirstduAlt
{
    internal class Program
    {
        static void Main(string[] args) => Console.WriteLine($"In {46 - (int.TryParse(Console.ReadLine(), out int alter) ? alter : 0)} Jahren werden Sie {46 + (int.TryParse(Console.ReadLine(), out alter) ? alter : 0)} alt.");
    }
}
