namespace TextHandler.Core;

public interface ITextEditorPlugin
{
    string Name { get; }
    string Description { get; }
    string Edit(string text);
}