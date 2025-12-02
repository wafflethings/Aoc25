using System.Reflection;

namespace Aoc25.Common;

public class InputFile
{
    public readonly string Content;
    public readonly string[] ContentLines;

    public InputFile(string name)
    {
        string targetInput = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new(), name);
        Content = File.ReadAllText(targetInput);
        ContentLines = File.ReadAllLines(targetInput);  // maybe not the best way to do this
    }
}