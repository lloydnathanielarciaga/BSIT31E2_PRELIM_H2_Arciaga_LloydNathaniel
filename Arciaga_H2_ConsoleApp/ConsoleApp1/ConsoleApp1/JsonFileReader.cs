namespace ConsoleApp1;

/// <summary>
/// Reads and displays the contents of JSON (.json) files.
/// </summary>
public class JsonFileReader : BaseFileReader
{
    /// <summary>
    /// Gets the supported format identifier for this reader.
    /// </summary>
    public override string SupportedFormat => "JSON";

    /// <summary>
    /// Reads the entire JSON file, counts the lines, and displays the first 100 characters.
    /// </summary>
    /// <param name="filePath">The full path to the .json file.</param>
    protected override void ParseContent(string filePath)
    {
        Console.WriteLine(" -> Opening JSON stream...");

        string fullText = File.ReadAllText(filePath);
        int lineCount = fullText.Split('\n').Length;

        Console.WriteLine($" -> Successfully parsed {lineCount} lines of JSON data.");

        string displayContent = fullText.Length > 100
            ? fullText.Substring(0, 100) + "..."
            : fullText;

        Console.WriteLine("\n--- First 100 Characters ---");
        Console.WriteLine(displayContent);
        Console.WriteLine("----------------------------\n");
    }
}