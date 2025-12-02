using Aoc25.Common;

namespace Aoc25.Day1;

public class Program
{
    private static void Main(string[] args)
    {
        InputFile file = new("day1.txt");
        Dial dial = new();
        
        foreach (string line in file.ContentLines)
        {
            (Dial.Direction direction, int amount) operation = ParseLine(line);
            dial.Turn(operation.direction, operation.amount);
        }
        
        Console.WriteLine($"Part1: {dial.TimesAtZero}");
        Console.WriteLine($"Part2: {dial.TimesPastZero}");
    }
    
    private static (Dial.Direction, int) ParseLine(string line)
    {
        Dial.Direction direction = line[0] == 'L' ? Dial.Direction.Left : Dial.Direction.Right;
        int amount = int.Parse(line[1..]);
        return (direction, amount);
    }
}