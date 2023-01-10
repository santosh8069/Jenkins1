using Serilog;
using Infrastructure.InfraServices;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddInfrastructure();
builder.Services.AddControllers();
//builder.Services.AddControllers()
//        .AddJsonOptions(options => {           
//            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;           
//            options.JsonSerializerOptions.PropertyNamingPolicy = null;
//        });
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.File("errorlog.txt"));
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
        .SetIsOriginAllowed(origin => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
