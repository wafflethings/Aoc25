using Aoc25.Common;

namespace Aoc25.Day2;

public class IdRange
{
    public long First { get; private set; }
    
    public long Second { get; private set; }
    
    public static IdRange Parse(string input)
    {
        string[] split = input.Split('-');
        return new IdRange(long.Parse(split[0]), long.Parse(split[1]));
    }

    public IdRange(long first, long second)
    {
        First = first;
        Second = second;
    }

    public long InvalidSum
    {
        get
        {
            long value = 0;

            if (First > Second)
            {
                (First, Second) = (Second, First);
            }
            
            for (long i = First; i  <= Second; i++)
            {
                if (i.ToString().StringRepeatsTwice())
                {
                    value += i;
                }
            }

            return value;
        }
    }
    
    public long InvalidSumPart2
    {
        get
        {
            long value = 0;

            if (First > Second)
            {
                (First, Second) = (Second, First);
            }
            
            for (long i = First; i  <= Second; i++)
            {
                if (i.ToString().StringRepeats())
                {
                    value += i;
                }
            }

            return value;
        }
    }
}