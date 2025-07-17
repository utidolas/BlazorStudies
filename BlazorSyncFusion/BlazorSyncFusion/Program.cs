using BlazorSyncFusion.Client.Pages;
using BlazorSyncFusion.Components;
using Microsoft.EntityFrameworkCore;
using DataAccessLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Register the data access layer services; create instances of ISqlDataAccess and IPeopleData
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IPeopleData, PeopleData>();
builder.Services.AddRazorPages(); // Configure Razor Pages services


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles(); // Serve Blazor framework files
app.UseRouting(); // Enable routing
app.MapRazorPages(); // Map Razor Pages
app.MapControllers(); // Map API controllers
app.MapFallbackToFile("index.html"); // Fallback to index.html for SPA routing
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorSyncFusion.Client._Imports).Assembly);

app.Run();
