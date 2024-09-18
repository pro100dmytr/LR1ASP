var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/company", () =>
{
    var company = new Company
    {
        Name = "LimoCorp",
        Address = "Limo Tech Street",
        Employees = 150,
        Industry = "Software Development"
    };

    return Results.Json(company);
});

app.MapGet("/random", () =>
{
    var random = new Random();
    int randomNumber = random.Next(0, 101);
    return Results.Json(new { Number = randomNumber });
});

app.Run();

public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Employees { get; set; }
    public string Industry { get; set; }
}
