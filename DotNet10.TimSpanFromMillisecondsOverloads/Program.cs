using System.Linq.Expressions;


TimeSpan timeSpanA = TimeSpan.FromMilliseconds(milliseconds: 832, microseconds: 0);
Console.WriteLine($"timeSpanA = {timeSpanA}");

TimeSpan timeSpanB = TimeSpan.FromMilliseconds(milliseconds: 832);
Console.WriteLine($"timeSpanB = {timeSpanA}");

Expression<Action> a = () => TimeSpan.FromMilliseconds(1000);