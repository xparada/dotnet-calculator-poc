using Calculator.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<CalculatorService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.MapGet("/calc/add", (double a, double b, CalculatorService svc)
    => Results.Ok(new { result = svc.Add(a, b) }));

app.MapGet("/calc/subtract", (double a, double b, CalculatorService svc)
    => Results.Ok(new { result = svc.Subtract(a, b) }));

app.MapGet("/calc/multiply", (double a, double b, CalculatorService svc)
    => Results.Ok(new { result = svc.Multiply(a, b) }));

app.MapGet("/calc/divide", (double a, double b, CalculatorService svc)
    => b == 0
        ? Results.BadRequest(new { error = "Division by zero" })
        : Results.Ok(new { result = svc.Divide(a, b) }));

app.Run();