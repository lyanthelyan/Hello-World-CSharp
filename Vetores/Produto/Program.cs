﻿namespace Produto;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    
        int n = int.Parse(Console.ReadLine());

        Product[] vect = new Product[n];

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vect[i] = new Product {Name = name, Price = price};

        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += vect[i].Price;
        }
        
        double avg = sum / n;

        Console.WriteLine($"Average Price: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}
