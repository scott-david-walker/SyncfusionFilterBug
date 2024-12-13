using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp2;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
_ = builder.Services.AddSyncfusionBlazor();

SyncfusionLicenseProvider
    .RegisterLicense("MzUwMDIwM0AzMjM3MmUzMDJlMzBrcUdxNlNSaVMwM1dFZHdsSHJUUVRhOVlqWnVzcHNOVHIvMm5kNXRlbUVBPQ==");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();