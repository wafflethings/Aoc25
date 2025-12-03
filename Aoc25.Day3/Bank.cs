namespace Aoc25.Day3;

public class Bank
{
    public static Bank Parse(string input)
    {
        int[] batteries = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            batteries[i] = int.Parse(input[i].ToString());
        }

        return new Bank(batteries);
    }
    
    public readonly int[] Batteries;

    public Bank(int[] batteries)
    {
        Batteries = batteries;
    }
    
    public long MaximumJoltage(int digitAmount)
    {
        string digits = string.Empty; // i would rather keep it as a long and add digit*10^y, but mathf.pow becomes imprecise
        int minimumIndex = 0;

        for (int i = 0; i < digitAmount; i++)
        {
            int[] currentRange = Batteries[(minimumIndex)..];
            int maximumIndex = (currentRange.Length - digitAmount) + i; // if there are 10 batteries, and digitAmount is 2, the first one needs to be from the 9th spot at most, or 8th index, 
            int digit = currentRange[..(maximumIndex + 1)].Max(); //needs +1 as range operator is not inclusive
            minimumIndex += Array.IndexOf(currentRange, digit) + 1; // needs to add so that its relative to the current range
            digits += digit.ToString();
        }

        return long.Parse(digits);
    }
}