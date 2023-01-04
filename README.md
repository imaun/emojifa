## Emojifa 😛
 Standard Emojis in a class library to use in .NET projects.
Contains standard unicode emojis ([full list](https://unicode.org/emoji/charts/full-emoji-list.html))

### How to use
- Clone this repo, build it and reference `Emojifa` assembly in you project.
- or, Install nuget package `Emojifa`


```csharp
using Emojifa;

var smile = Emojis.RollingOnTheFloorLaughing;
Console.WriteLine($"{smile}"); //prints : 🤣
```


The `EmoijiData` class provides extra metadata for each emoji which contains the following properties :
- **Description** (name and title for the emoji)
- **Category** (emojis have different categories)
- **Aliases** (emojis also known with this aliases)
- **Tags** (emojis tags are for better categorization)
- **PersianKeywords** (tags for persian language **! not completed yet**)
- **UnicodeVersion**
- **iOsVersion**


### Status
The library is under development.
We need to develop functionalities like searching, dictionary and finding emojis based on persian words.
So pull requests are always welcomed.



