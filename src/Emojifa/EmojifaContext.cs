using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Emojifa;


public static class EmojifaContext
{
    public static async Task<IReadOnlyCollection<EmojiJsonItem>> GetJsonDataAsync()
    {
        await using var stream = Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream("Emojifa.Resources.emoji.json");
        using var reader = new StreamReader(stream!);
        var content = await reader.ReadToEndAsync();
        var data = JsonConvert.DeserializeObject<IReadOnlyCollection<EmojiJsonItem>>(content);

        return data!;
    }
    
    
    
}