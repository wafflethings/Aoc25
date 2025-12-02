namespace Aoc25.Day1;

public class Dial
{
    public int Value { get; private set; } = 50;
    public int TimesAtZero { get; private set; } = 0;
    public int TimesPastZero { get; private set; } = 0;

    private static List<int> s_multiples = new();

    static Dial()
    {
        for (int i = -1000; i < 1000; i++)
        {
            s_multiples.Add(i * 100);
        }
    }
    
    public void Turn(Direction direction, int amount)
    {
        int oldValue = Value;
        amount *= (direction == Direction.Left ? -1 : 1);
        Value += amount;

        foreach (int multiple in s_multiples)
        {
            if (Value == multiple)
            {
                TimesAtZero++;
            }
            
            if (direction == Direction.Right)
            {
                if (MathF.Min(oldValue, Value) < multiple && multiple <= MathF.Max(oldValue, Value))
                {
                    TimesPastZero++;
                }
            }
            
            if (direction == Direction.Left)
            {
                if (MathF.Min(oldValue, Value) <= multiple && multiple < MathF.Max(oldValue, Value))
                {
                    TimesPastZero++;
                }
            }
        }
    }
    
    public enum Direction
    {
        Left,
        Right
    }
}