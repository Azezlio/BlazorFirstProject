using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectKata
{
    public class Program
    {
        // Entry of the app
        public static async Task Main(string[] args)
        {
            // Creates web assembly host
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            // Defines the root component. The tag is related to the one defined in index.html
            builder.RootComponents.Add<App>("#app");

            // injection of http client
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //run web assembly host
            await builder.Build().RunAsync();
        }
    }
}
