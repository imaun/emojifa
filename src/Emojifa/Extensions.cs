using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Emojifa
{
    public static partial class Emoji
    {

        public static EmojiData[] FindByTitle(string title) {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title));

            return Emoji.All.Where(
                _ => _.Title.ToUpper().Contains(title.ToUpper())).ToArray();
        }


        public static string[] FindRawEmojiesByTitle(string title) {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title));

            return Emoji.All.Where(_ => _.Title.ToUpper().Contains(title.ToUpper()))
                                    .Select(_=> _.Raw).ToArray();
        }


        public static string ConvertHexCodesToEmoji(string text) {
            return string.Empty;
        }
    }
}
