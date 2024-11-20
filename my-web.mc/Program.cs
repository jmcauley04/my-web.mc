using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using my_web.mc;
using my_web.mc.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://swampsofdouglas.mywire.org/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:3001/") });

builder.Services.AddSingleton<ProjectsService>();

await builder.Build().RunAsync();
