namespace Aoc25.Common;

public static class ArrayUtilities
{
    public static string BetterString<T>(this T[] array) => $"[{string.Join(",", array)}]";
}