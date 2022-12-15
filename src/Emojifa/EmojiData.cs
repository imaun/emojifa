using System;

namespace Emojifa
{

    public class EmojiData
    {
        public string Title { get; set; }
        public string HexCode => $"U+{Convert.ToUInt16(Raw[0]):X4}";
        public string Raw { get; set; }
        public string? Category { get; set; }
        public string[] Aliases { get; set; }
        public string[]? Tags { get; set; }
        public string? UnicodeVersion { get; set; }
        public string? IosVersion { get; set; }
        public string[]? PersianNames { get; set; }
        public string? Filename { get; set; }
    }
}
