using Emojifa;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var _con = true;
while(_con) {
    Console.WriteLine("Please enter an emoji name or alias : ");
    var alias = Console.ReadLine();
    var search = Emoji.All.FirstOrDefault(_ => _.Aliases.Contains(alias));
    if (search == null) {
        Console.WriteLine("Not found.");
    }
    else {
        Console.WriteLine($"The UnicodeCode is : '{search.HexCode}'");
        _con = false;
    }

}

Console.WriteLine("Goodbye!");

