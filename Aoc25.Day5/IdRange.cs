namespace Aoc25.Day5;

public class IdRange
{
    public static IdRange Parse(string input)
    {
        string[] split = input.Split("-");
        return new IdRange(long.Parse(split[0]), long.Parse(split[1]));
    }

    public long Size => _end - _start;

    private long _start;
    private long _end;

    public IdRange(long start, long end)
    {
        if (end < start)
        {
            (start, end) = (end, start);
        }

        _start = start;
        _end = end;
        Console.WriteLine($"Range {_start}-{_end}");
    }

    public bool Contains(long id) => _start <= id && id <= _end;
}