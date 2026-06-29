using System;
using System.Linq;
using TextHandler.Core;

namespace TextHandler.Plugins.RemoveDuplicateLinesPlugin;

public class RemoveDuplicateLinesPlugin : ITextEditorPlugin
{
    public string Name => "Remove Duplicate Lines Plugin";
    
    public string Description => "Removes duplicate lines from the text.";
    
    public string Edit(string text)
    {
        if (string.IsNullOrEmpty(text)) return string.Empty;
        
        var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        var uniqueLines = lines.Distinct();
        return string.Join(Environment.NewLine, uniqueLines);
    }
}
