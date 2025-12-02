namespace Aoc25.Common;

public static class StringUtils
{
    public static bool StringRepeats(this string input)
    {
        for (int i = 0; i < input.Length / 2; i++)
        {
            int sliceLength = i + 1;
            
            if (input.Length % sliceLength != 0) // no point checking, cant divide
            {
                continue;
            }

            string slice = input[..sliceLength];

            if (input == string.Concat(Enumerable.Repeat(slice, input.Length / sliceLength)))
            {
                return true;
            }
        }
        
        return false;
    }
    
    public static bool StringRepeatsTwice(this string input)
    {
        if (input.Length % 2 != 0)
        {
            return false; // impossible
        }

        string half = input[..(input.Length / 2)];
        return (half + half) == input;
    }
}