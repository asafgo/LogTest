var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Logging.AddEventLog(eventLogSettings =>
{
    eventLogSettings.LogName = "LogTest";
    eventLogSettings.SourceName = "Test1";
});




// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
