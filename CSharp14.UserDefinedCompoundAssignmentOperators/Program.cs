
var range = new TimeRange(TimeSpan.FromHours(1), TimeSpan.FromHours(2));
range += TimeSpan.FromMinutes(30);

Console.WriteLine(range);



class TimeRange
{
    public TimeSpan Begin { get; private set; }
    public TimeSpan End { get; private set; }

    public TimeRange(TimeSpan begin, TimeSpan end)
    {
        Begin = begin;
        End = end;
    }

    public void operator +=(TimeSpan offset)
    {
        Begin += offset;
        End += offset;
    }

    public override string ToString()
    {
        return $"Begin: {Begin}, End: {End}";
    }
}