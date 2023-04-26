using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        int sum = numbers.Sum();
        int max = numbers.Max();
        int min = numbers.Min();
        double average = numbers.Average();
        int count = numbers.Count();
        int product = numbers.Aggregate(1, (x, y) => x * y);
        
        Console.WriteLine("The sum of the numbers is: " + sum);
        Console.WriteLine("The maximum number is: " + max);
        Console.WriteLine("The minimum number is: " + min);
        Console.WriteLine("The average of the numbers is: " + average);
        Console.WriteLine("The count of the numbers is: " + count);
        Console.WriteLine("The product of the numbers is: " + product);
        Console.ReadLine();
    }
}