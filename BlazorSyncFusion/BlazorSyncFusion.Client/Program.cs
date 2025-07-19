using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DataAccessLibrary; // Add the namespace
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the SQL data access layer service
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IOrdersData, OrdersData>();

await builder.Build().RunAsync();
