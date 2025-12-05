using Aoc25.Common;

namespace Aoc25.Day5;

public class Program
{
    private static void Main(string[] args)
    {
        InputFile file = new("day5.txt");

        bool doingRanges = true;
        List<IdRange> ranges = new();
        int sum = 0;
        long sum2 = 0;

        foreach (string line in file.ContentLines)
        {
            if (line == string.Empty)
            {
                Console.WriteLine("Empty line, switching mode");
                doingRanges = false;
                continue;
            }

            if (doingRanges)
            {
                ranges.Add(IdRange.Parse(line));
                sum2 += IdRange.Parse(line).Size;
                continue;
            }

            long id = long.Parse(line);
            Console.WriteLine($"Id {id}");

            if (ranges.Any(x => x.Contains(id)))
            {
                sum++;
            }
        }

        Console.WriteLine($"Part 1: {sum}");
        Console.WriteLine($"Part 2: {sum2}");
    }
}