using Leonardo;
using System;

class Program
{
    static void Main(string[] args)
    {
        var fibonacci = new Fibonacci();
        Console.WriteLine("Entrez un nombre : ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Le {n}ème nombre de Fibonacci est : {fibonacci.GetFibonacciNumber(n)}");
    }
}