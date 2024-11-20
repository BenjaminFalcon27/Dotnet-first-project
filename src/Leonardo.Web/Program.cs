using Leonardo;

var builder = WebApplication.CreateBuilder(args);
builder.Environment.EnvironmentName = "Development";

var app = builder.Build();

app.MapGet("/Fibonacci", async (int n) =>
{
    var fibonacci = new Fibonacci();
    return Results.Ok(fibonacci.GetFibonacciNumber(n));
});

app.Run();