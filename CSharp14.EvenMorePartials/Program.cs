Console.WriteLine("Hello World!");


// Partial constructors

partial class MyPartialClass1
{
    public partial MyPartialClass1();
}

partial class MyPartialClass1
{
    // Partial member may not have multiple defining declarations.
    // public partial MyPartialClass1();
}

partial class MyPartialClass1
{
    public partial MyPartialClass1()
    {
        Console.WriteLine("Constructor...");
    }
}

partial class MyPartialClass1
{
    // Partial member may not have multiple implementing declarations.
    // public partial MyPartialClass1()
    // {
    //     Console.WriteLine("Constructor...");
    // }
}

// Partial events

partial class MyPartialClass2
{
    public partial event Action<int, string> MyEvent;
}

partial class MyPartialClass2
{
    private event Action<int, string> _myEvent;
    public partial event Action<int, string> MyEvent
    {
        add { _myEvent += value; }
        remove { _myEvent -= value; }
    }
}