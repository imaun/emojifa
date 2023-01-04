namespace Emojifa;

public class EmojiData
{
    
    public string Emoji { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string[]? Aliases { get; set; }
    public string[]? Tags { get; set; }
    public string[]? Emoticons { get; set; }
    public string[]? PersianKeywords { get; set; }
    public string? UnicodeVersion { get; set; }
    public string? IosVersion { get; set; }


    public override string ToString()
    {
        return Emoji;
    }
}