using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddValidation();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapPost("/feedback/{productId}", ([Range(1000, 9999)] int productId, Feedback feedback) =>
{
    Console.WriteLine(feedback);
    return Results.Created();
});

app.Run();

//public class Feedback
//{
//    [Range(typeof(DateTime), "2000-01-01", "2030-12-31")]
//    public DateTime Timestamp { get; set; }

//    public string? Author { get; set; }

//    [Required]
//    public string Contents { get; set; } = default!;
//}

public record Feedback(
    [property: Range(typeof(DateTime), "2000-01-01", "2030-12-31")] DateTime Timestamp,
    string? Author,
    [property: Required] string Contents
);