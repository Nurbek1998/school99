using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using School99.Landing;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");


await builder.Build().RunAsync();
