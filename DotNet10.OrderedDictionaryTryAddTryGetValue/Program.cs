

var dict = new OrderedDictionary<string, WindDirection>
{
    ["N"] = WindDirection.North,
    ["E"] = WindDirection.East,
    ["S"] = WindDirection.South
};

dict.TryAdd("W", WindDirection.West, out int index);
Console.WriteLine($"\"W\" added with index '{index}'");

dict.TryGetValue("N", out WindDirection directionN, out int indexN);
Console.WriteLine($"\"N\" has index '{indexN}'");
dict.TryGetValue("E", out WindDirection directionE, out int indexE);
Console.WriteLine($"\"E\" has index '{indexE}'");
dict.TryGetValue("S", out WindDirection directionS, out int indexS);
Console.WriteLine($"\"S\" has index '{indexS}'");


enum WindDirection
{
    North,
    East,
    South,
    West
}