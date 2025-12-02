using Aoc25.Common;

namespace Aoc25.Day2;

public class Program
{
    private static void Main(string[] args)
    {
        InputFile file = new("day2.txt");
        IEnumerable<IdRange> idRanges = file.Content.Split(",").Select(IdRange.Parse);

        long sum = 0;
        long sum2 = 0;
        
        foreach (IdRange range in idRanges)
        {
            sum += range.InvalidSum;
            sum2 += range.InvalidSumPart2;
        }
        
        Console.WriteLine("Part 1: " + sum);
        Console.WriteLine("Part 2: " + sum2);
    }
}