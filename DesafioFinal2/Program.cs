using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string[] valores1 = Console.ReadLine().Split(' ');
        int a = Int32.Parse(valores1[0]);
        int b = Int32.Parse(valores1[1]);
        int c = Int32.Parse(valores1[2]);

        int MAIORAB = (a + b + Math.Abs(a - b) ) / 2;

        int MAIOR = (MAIORAB + c + Math.Abs(MAIORAB - c)) / 2;

        Console.WriteLine($"{MAIOR} eh o maior");

    }
}