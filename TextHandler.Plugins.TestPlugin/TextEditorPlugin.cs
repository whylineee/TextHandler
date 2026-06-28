using TextHandler.Core;

namespace TextHandler.Plugins.TestPlugin;

public class TextEditorPlugin: ITextEditorPlugin
{
    public string Name => "Text Editor Plugin";
    public string Description => "This is a test plugin for text editing.";
    public string Edit(string text)
    {
        return "Edited Text: " + text;
    }
}