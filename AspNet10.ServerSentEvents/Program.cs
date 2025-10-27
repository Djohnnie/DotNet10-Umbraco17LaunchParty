using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/health", (CancellationToken cancellationToken) =>
{
    var realtimeHeartRate = GetHeartRate(cancellationToken);
    return TypedResults.ServerSentEvents(realtimeHeartRate, eventType: "heartRate");
});

app.Run();

async IAsyncEnumerable<HeartRateRecord> GetHeartRate([EnumeratorCancellation] CancellationToken cancellationToken)
{
    while (!cancellationToken.IsCancellationRequested)
    {
        var heartRate = Random.Shared.Next(50, 120);
        yield return new HeartRateRecord(heartRate);
        await Task.Delay(1000, cancellationToken);
    }
}

internal record HeartRateRecord(int HeartRate);