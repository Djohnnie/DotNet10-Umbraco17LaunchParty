// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer? customer = null;

if (customer is not null)
{
    customer.Order = GetCurrentOrder();
}

customer?.Order = GetCurrentOrder();



static string GetCurrentOrder()
{
    Console.WriteLine($"{nameof(GetCurrentOrder)} called!");
    return "Order123";
}

class Customer
{
    public string Order { get; set; }
}