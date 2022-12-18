using System.Text;
using System.Globalization;

namespace Emojifa.Cli;

public static class EmojifaBuilder
{

    public static async Task BuildArrayAsync()
    {
        var all = await EmojifaContext.GetJsonDataAsync();
        var sb = new StringBuilder();
        sb.AppendLine("namespace Emojifa;");
        sb.AppendLine("");
        sb.AppendLine("public static partial class Emojis");
        sb.AppendLine("{");
        foreach (var item in all)
        {
            sb.AppendLine($"    public static EmojiData {getEmojiName(item.description)} = new EmojiData ");
            sb.AppendLine("     {");
            sb.AppendLine($"         Emoji = \"{item.emoji}\", ");
            sb.AppendLine($"         Description = \"{item.description}\", ");
            sb.AppendLine($"         Category = \"{item.category}\", ");
            if (item.aliases != null && item.aliases.Any())
            {
                int totalAliases = item.aliases.Length;
                int idx = 1;
                sb.AppendLine("        Aliases = new[] ");
                sb.AppendLine("        {");
                foreach (var alias in item.aliases)
                {
                    string _next = idx < totalAliases ? "," : "";
                    sb.AppendLine($"        \"{alias}\"" + _next);
                    idx++;
                }
                sb.AppendLine("        }, ");
            }
            
            if (item.tags != null && item.tags.Any())
            {
                int totalTags = item.tags.Length;
                int idx = 1;
                sb.AppendLine($"        Tags = new[] ");
                sb.AppendLine("        {");
                foreach (var tag in item.tags)
                {
                    string _next = idx < totalTags ? "," : "";
                    sb.AppendLine($"        \"{tag}\"" + _next);
                    idx++;
                }
                sb.AppendLine("        }, ");
            }
            
            if (item.emoticons != null && item.emoticons.Any())
            {
                int totalEmos = item.emoticons.Length;
                int idx = 1;
                sb.AppendLine($"        Emoticons = new[] ");
                sb.AppendLine("        {");
                foreach (var emo in item.emoticons)
                {
                    string _next = idx < totalEmos ? "," : "";
                    sb.AppendLine("         @" + $"\"{emo}\"" + _next);
                    idx++;
                }
                sb.AppendLine("        }, ");
            }

            sb.AppendLine($"       UnicodeVersion = \"{item.unicode_version}\", ");
            sb.AppendLine($"       IosVersion = \"{item.ios_version}\" ");

            sb.AppendLine("     };");
        }
        
        sb.AppendLine("");
        sb.AppendLine("}");

        using var streamWriter = new StreamWriter("EmojiArray.cs");
        await streamWriter.WriteAsync(sb.ToString());
        await streamWriter.FlushAsync();
        streamWriter.Close();
    }

    private static string getEmojiName(string description)
    {
        var words = description.Split(' ');
        var name = "";
        foreach (var word in words)
        {
            var fixWord = word
                .Replace(":", "").Replace("-", "")
                .Replace("&", "").Replace(".", "")
                .Replace("’", "");
            name += toUpperFirstLetter(fixWord);
        }

        return name;
    }

    private static string toUpperFirstLetter(string what)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(what);
    }
}