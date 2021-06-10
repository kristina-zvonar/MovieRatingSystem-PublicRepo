using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MovieRatingSystem.Services.Contracts;
using MovieRatingSystem.Services.Implementations;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace MovieRatingSystem.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });            
            builder.Services.AddDevExpressBlazor();

            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("Auth0", options.ProviderOptions);
                options.ProviderOptions.ResponseType = "code";
            });

            builder.Services.AddHttpClient<IContentDataService, ContentDataService>("ServerAPI",
                             client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
                            .CreateClient("ServerAPI"));

            await builder.Build().RunAsync();
        }
    }
}
