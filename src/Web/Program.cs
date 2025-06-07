using Infrastrucutre.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__Default");

builder.Services.AddDbContext<ComputerClubDbContext>(options => options.UseNpgsql(connectionString));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();
}

app.MapGet("/", () => "Computer Club");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();