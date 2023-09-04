using Microsoft.EntityFrameworkCore;
using PlatformDemo.Core.Data;
using PlatformDemo.Core.Data.Repositories;
using PlatformDemo.Core.Data.Services;
using PlatformDemo.Core.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient(typeof(ICustomerOrderSummaryRepository), typeof(CustomerOrderSummaryRepository));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<LocalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDbContext") ?? 
        throw new InvalidOperationException("Connection string 'LocalDbContext' not found.")));


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    DataService.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
