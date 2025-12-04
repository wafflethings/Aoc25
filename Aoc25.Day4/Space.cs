namespace Aoc25.Day4;

public class Space
{
    public static Space[,] ParseMap(string[] lines)
    {
        Space[,] map = new Space[lines[0].Length, lines.Length];
        
        for (int y = 0; y < lines.Length; y++)
        {
            string line = lines[y];
            
            for (int x = 0; x < line.Length; x++)
            {
                map[x, y] = new Space(line[x] == '@', x, y, map);
            }
        }

        return map;
    }

    public bool Occupied;
    private int _x;
    private int _y;
    private Space[,] _source;

    public bool Accessible
    {
        get
        {
            int occupiedSum = 0;
            
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        continue;
                    }

                    occupiedSum += (GetAdjacent(x, y)?.Occupied ?? false) ? 1 : 0;
                }
            }

            return occupiedSum < 4;
        }
    }
    
    public Space(bool occupied, int x, int y, Space[,] source)
    {
        Occupied = occupied;
        _x = x;
        _y = y;
        _source = source;
    }

    public Space? GetAdjacent(int x, int y)
    {
        int targetX = _x + x;
        int targetY = _y + y;
        
        if (targetX < 0 || targetX > (_source.GetLength(0) - 1) || targetY < 0 || targetY > (_source.GetLength(1) - 1))
        {
            return null;
        }
        
        return _source[targetX, targetY];
    }
}