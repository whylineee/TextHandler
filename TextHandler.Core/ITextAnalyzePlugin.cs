namespace TextHandler.Core;

public interface ITextAnalyzePlugin
{
    string Name { get; }
    string Description { get; }
    void Analyze(string text);
    void PrintResult();
}