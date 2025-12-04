using Aoc25.Common;

namespace Aoc25.Day4;

public class Program
{
    private static void Main(string[] args)
    {
        InputFile file = new("day4.txt");
        Space[,] map = Space.ParseMap(file.ContentLines);
        int sum = 0;
        
        Console.WriteLine(MapToString(map));
        
        foreach (Space space in map)
        {
            if (space.Occupied && space.Accessible)
            {
                sum++;
            }
        }
        
        Console.WriteLine($"Part 1: {sum}");

        int cleanedUp = 0;
        int cleanedUpBefore = -1;
        
        while (cleanedUp != cleanedUpBefore)    // this is slow and feels cheap but it works so i dont care 
        {
            cleanedUpBefore = cleanedUp;
            
            foreach (Space space in map)
            {
                if (space.Occupied && space.Accessible)
                {
                    space.Occupied = false;
                    cleanedUp++;
                }
            }
        }
        
        Console.WriteLine($"Part 2: {cleanedUp}");
    }
    
    public static string MapToString(Space[,] map)
    {
        string result = string.Empty;
        
        for (int y = 0; y < map.GetLength(1); y++)
        {
            string line = string.Empty;
            
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Space space = map[x, y];
                line += space.Occupied ? (space.Accessible ? "x" : "@") : ".";
            }

            result += line + "\n";
        }

        return result;
    }
}