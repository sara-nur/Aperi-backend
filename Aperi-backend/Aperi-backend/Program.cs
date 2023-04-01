using Aperi_backend.Database;
using Microsoft.EntityFrameworkCore;

#region Database connection

//Create a configuration with a path to appsettings.json file which holds all of the settings:

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false)
                    .Build();

var builder = WebApplication.CreateBuilder(args);

// Create a database context using SQL server with a connection string of "database"
builder.Services.AddDbContext<AppDbContext>(options =>
{
    _ = options.UseSqlServer(configuration.GetConnectionString("database"));
    //_ = options.UseLazyLoadingProxies();
});
#endregion

#region Swagger initialization
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region App initialization

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

app.UseCors(options =>
        options.SetIsOriginAllowed(allow => _ = true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion
