namespace TextHandler.Plugins.TestPlugin;

public class TestAnalyzePlugin : TextHandler.Core.ITextAnalyzePlugin
{
    public string Name => "Test Plugin";

    public string Description => "This is a test plugin for text analysis.";

    public void Analyze(string text)
    {
        // Implement your text analysis logic here
        Console.WriteLine($"Analyzing text: {text}");
    }

    public void PrintResult()
    {
        // Implement your result printing logic here
        Console.WriteLine("Analysis complete. No results to display.");
    }
}