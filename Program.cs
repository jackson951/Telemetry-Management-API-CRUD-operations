using CMPG323_PROJECT2_39990966.Data; // Replace with your actual namespace
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Correctly register the DbContext
builder.Services.AddDbContext<TelemetryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TelemetryDatabase")));

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();