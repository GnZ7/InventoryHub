using InventoryHub.Api.Data;
using InventoryHub.Api.Features.Products;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' is missing.");

builder.Services.AddDbContext<InventoryHubContext>(options =>
    options.UseSqlite(connectionString));

var frontEndUrl = builder.Configuration["FrontEndUrl"]
    ?? throw new InvalidOperationException("FrontEndUrl configuration is missing.");

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins(frontEndUrl)
              .AllowAnyHeader()
              .AllowAnyMethod());
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<InventoryHubContext>();
    await db.Database.MigrateAsync();
    await DbSeeder.SeedAsync(db);
}

app.UseCors();

app.UseHttpsRedirection();

app.MapProductsEndpoints();

app.Run();