using Aoc25.Common;

namespace Aoc25.Day3;

public class Program
{
    private static void Main(string[] args)
    {
        InputFile file = new("day3.txt");
        Bank[] banks = new Bank[file.ContentLines.Length];
        long sum = 0;
        long sum2 = 0;

        for (int i = 0; i < file.ContentLines.Length; i++)
        {
            banks[i] = Bank.Parse(file.ContentLines[i]);
            sum += banks[i].MaximumJoltage(2);
            sum2 += banks[i].MaximumJoltage(12);
        }
        
        Console.WriteLine($"Part 1: {sum}");
        Console.WriteLine($"Part 2: {sum2}");
    }
}