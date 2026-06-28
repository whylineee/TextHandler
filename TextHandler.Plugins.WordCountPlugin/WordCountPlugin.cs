namespace TextHandler.Plugins.CharCountPlugin;

using TextHandler.Core;

public class WordCountPlugin : ITextAnalyzePlugin
{
    public string Name => "Word Count Plugin";

    public string Description => "This plugin counts the total number of words in the text.";

    private int _wordCount;

    public void Analyze(string text)
    {
        _wordCount = text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public void PrintResult()
    {
        Console.WriteLine($"Total number of words: {_wordCount}");
    }
}


