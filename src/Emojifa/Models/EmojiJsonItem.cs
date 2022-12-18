namespace Emojifa
{
    public class EmojiJsonItem
    {

        public EmojiJsonItem()
        {
        }
        
        public string emoji { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string[]? aliases { get; set; }
        public string[]? tags { get; set; }
        public string[]? emoticons { get; set; }
        public string? unicode_version { get; set; }
        public string? ios_version { get; set; }

        public string[] Aliases => aliases ?? new[] { "" };
    }
}