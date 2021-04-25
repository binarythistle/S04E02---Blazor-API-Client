using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorAPIClient.DataServices;

namespace BlazorAPIClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("BlazoreAPIClient has started...");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["api_base_url"]) });

            builder.Services.AddHttpClient<ISpaceXDataService, GraphQLSpaceXDataService>
                (spds => spds.BaseAddress = new Uri(builder.Configuration["api_base_url"]));

            await builder.Build().RunAsync();
        }
    }
}
