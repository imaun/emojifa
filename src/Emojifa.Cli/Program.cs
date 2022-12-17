using Emojifa;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var _con = true;
var all = await EmojifaContext.GetJsonDataAsync();
foreach (var item in all.Take(10))
{
    Console.WriteLine($"{item.emoji}: {item.Aliases[0]}");
}

while(_con) {
    Console.WriteLine("Please enter an emoji name or alias : ");
    var alias = Console.ReadLine();
    // var search = Emoji.All.FirstOrDefault(_ => _.Aliases.Contains(alias));
    var search = all.FirstOrDefault(_ => _.Aliases.Contains(alias));
    if (search == null) {
        Console.WriteLine("Not found.");
    }
    else {
        Console.WriteLine($"The emoji is : '{search.emoji}'");
        _con = false;
    }

}

Console.WriteLine("Goodbye!");

