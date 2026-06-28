/*
 * Project: TextHandler
 * 
 * Teacher: Vasyl Kovalov raid3r81@gmail.com
 *
 * Team:
 *  Marko Savyn msavin901001@gmail.com
 *  Kryskov Maksym kriskovmaksim6@gmail.com
 *  Ivanov Yehor yehorivanovd@gmail.com
 *  Denys Gvozdik den159chik753@gmail.com
 *  Budnyi Matvii kotikmurcik11@gmail.com
 * 
*/

const string text = """
           Document Processing Test File
           
           This document was created to test different text processing plugins.
           
           John Smith works as a software engineer at Example Solutions Ltd.
           His email address is john.smith@example.com, and his backup email is support@test.org.
           
           For business inquiries, please call +1-202-555-0175 or +44 20 7946 0958.
           
           The project officially started on 15 March 2025 and is expected to finish on 30 September 2026.
           
           Useful websites:
           https://example.com
           https://docs.example.com
           https://github.com/example/project
           
           The quick brown fox jumps over the lazy dog.
           The quick brown fox jumps over the lazy dog.
           
           Artificial Intelligence is changing the way people work.
           Machine learning, cloud computing, and cybersecurity are becoming increasingly important.
           
           This paragraph contains several repeated words.
           Document document DOCUMENT processing Processing processing.
           
           The following line contains extra spaces.
           
           
           This      line      contains      multiple      spaces.
           
           
           Some numbers:
           15
           256
           1024
           3.14159
           -42
           
           The longest English word in this document is:
           pseudopseudohypoparathyroidism
           
           Palindrome examples:
           level
           madam
           racecar
           
           Shopping list:
           - Apples
           - Bananas
           - Milk
           - Bread
           - Cheese
           
           End of document.
           
           
           """;

var analyzePlugins = new List<TextHandler.Core.ITextAnalyzePlugin>
{
    new TextHandler.Plugins.TestPlugin.TestAnalyzePlugin(),
    new TextHandler.Plugins.CharCountPlugin.WordCountPlugin(),
    new TextHandler.Plugins.LongestWord(),
    new TextHandler.Plugins.CharCounterPlugin(),
    new TextHandler.Plugins.MostUsedWordsPlugin()
};

foreach (var plugin in analyzePlugins)
{
    Console.WriteLine($"Plugin: {plugin.Name}");
    Console.WriteLine($"Description: {plugin.Description}");
    plugin.Analyze(text);
    plugin.PrintResult();
}
