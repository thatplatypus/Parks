using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Parks.Domain.Services;
using Parks.Repository;
using Parks.Server;
using Parks.Server.NationalParks;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient();

builder.Services.AddTransient<IParkRepositoryService, MockParkRepositoryService>();

builder.Services.AddHttpClient<INationalParkClient, NationalParkClient>("NationalPark", client => {
    var apiKey = builder.Configuration.GetSection("NationalParks").Get<NationalParkClientSettings>()?.ApiKey;

    client.BaseAddress = new Uri("https://developer.nps.gov/api/v1/");
    client.DefaultRequestHeaders.Add("x-api-key", apiKey);
});

await builder.Build().RunAsync();