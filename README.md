# Sdcb.Collections

# BidirectionalDictionary<TFirst, TSecond>
Copied from https://github.com/dotnet/corefxlab/pull/2613

Example: 
```csharp
var dict = new BidirectionalDictionary<string, int>();
dict["One"] = 1;
dict["Two"] = 2;
dict["Three"] = 3;
dict["Four"] = 4;

Console.WriteLine(dict["Two"]);     // 2
Console.WriteLine(dict.Reverse[2]); // Two
```
