using TextHandler.Core;

namespace TextHandler.Plugins.UpperCasePlugin;

public class UpperCasePlugin : ITextEditorPlugin
{
    public string Name => "Upper Case Plugin";
    
    public string Description => "Converts all text to upper case.";
    
    public string Edit(string text)
    {
        return text?.ToUpper() ?? string.Empty;
    }
}
