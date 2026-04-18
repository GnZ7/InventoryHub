using InventoryHub.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var backEndUrl = builder.Configuration["BackEndUrl"] ??
        throw new InvalidOperationException("BackEndUrl configuration is missing.");

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(backEndUrl) });

await builder.Build().RunAsync();
