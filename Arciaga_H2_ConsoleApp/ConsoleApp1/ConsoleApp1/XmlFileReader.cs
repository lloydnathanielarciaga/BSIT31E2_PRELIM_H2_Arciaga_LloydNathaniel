namespace ConsoleApp1;

/// <summary>
/// Reads and displays the contents of XML (.xml) files.
/// </summary>
public class XmlFileReader : BaseFileReader
{
    /// <summary>
    /// Gets the supported format identifier for this reader.
    /// </summary>
    public override string SupportedFormat => "XML";

    /// <summary>
    /// Reads the entire XML file, counts the lines, and displays the first 100 characters.
    /// </summary>
    /// <param name="filePath">The full path to the .xml file.</param>
    protected override void ParseContent(string filePath)
    {
        Console.WriteLine(" -> Opening XML stream...");

        string fullText = File.ReadAllText(filePath);
        int lineCount = fullText.Split('\n').Length;

        Console.WriteLine($" -> Successfully parsed {lineCount} lines of XML data.");

        string displayContent = fullText.Length > 100
            ? fullText.Substring(0, 100) + "..."
            : fullText;

        Console.WriteLine("\n--- First 100 Characters ---");
        Console.WriteLine(displayContent);
        Console.WriteLine("----------------------------\n");
    }
}