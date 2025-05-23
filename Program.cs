using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LearnShop;
using LearnShop.Services.Interfaces;
using LearnShop.Models;
using LearnShop.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IEbookService, EbookService>();
builder.Services.AddScoped<IOrderService, OrderService>();

await builder.Build().RunAsync();
