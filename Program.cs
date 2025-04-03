using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using oop_a_2025_movies_74476.Data;
using oop_a_2025_movies_74476.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<oop_a_2025_movies_74476Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("oop_a_2025_movies_74476Context") ?? throw new InvalidOperationException("Connection string 'oop_a_2025_movies_74476Context' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
