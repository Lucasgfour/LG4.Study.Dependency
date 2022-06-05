// -----------------------------------------------------------------------------------------------------------

using LG4.Study.ApplicationWeb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddControllers();

var cnnString = builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

Dependency.Configure(builder.Services, cnnString);

// -----------------------------------------------------------------------------------------------------------

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.MapGet("/", () => "Servidor API - Study.Dependency");

app.Run();

// -----------------------------------------------------------------------------------------------------------
