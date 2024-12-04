using Leonardo;

var builder = WebApplication.CreateBuilder(args);
builder.Environment.EnvironmentName = "Development";
builder.WebHost.UseUrls("http://*:8080");
var app = builder.Build();

app.MapGet("/Fibonacci", () =>
{
    var n = 10;
    var fibonacci = new Fibonacci();
    return fibonacci.GetFibonacciNumber(n).ToString(); 
});

app.Run();