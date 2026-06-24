namespace ConsoleApp1;

/// <summary>
/// Reads and displays the contents of comma-separated value (.csv) files.
/// </summary>
public class CsvFileReader : BaseFileReader
{
    /// <summary>
    /// Gets the supported format identifier for this reader.
    /// </summary>
    public override string SupportedFormat => "CSV";

    /// <summary>
    /// Reads the entire CSV file, counts the rows, and displays the first 100 characters.
    /// </summary>
    /// <param name="filePath">The full path to the .csv file.</param>
    protected override void ParseContent(string filePath)
    {
        Console.WriteLine(" -> Opening CSV stream...");

        string fullText = File.ReadAllText(filePath);
        int lineCount = fullText.Split('\n').Length;

        Console.WriteLine($" -> Successfully parsed {lineCount} rows of data.");

        string displayContent = fullText.Length > 100
            ? fullText.Substring(0, 100) + "..."
            : fullText;

        Console.WriteLine("\n--- First 100 Characters ---");
        Console.WriteLine(displayContent);
        Console.WriteLine("----------------------------\n");
    }
}