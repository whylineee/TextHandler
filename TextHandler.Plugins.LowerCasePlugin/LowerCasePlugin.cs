using TextHandler.Core;

namespace TextHandler.Plugins.LowerCasePlugin;

public class LowerCasePlugin : ITextEditorPlugin
{
    public string Name => "Lower Case Plugin";
    
    public string Description => "Converts all text to lower case.";
    
    public string Edit(string text)
    {
        return text?.ToLower() ?? string.Empty;
    }
}
