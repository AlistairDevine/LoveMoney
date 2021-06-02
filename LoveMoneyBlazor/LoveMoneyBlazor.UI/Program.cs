using AdaptiveCards.Blazor.Extensions;
using Blazored.LocalStorage;
using LoveMoneyBlazor.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoveMoneyBlazor.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //DI container
            builder.Services.AddSingleton<ArticleService>();
            builder.Services.AddBlazorAdaptiveCards()
                .AddTemplate<Article>(Schemas.ImageGallery)
                .AddFileTemplate("Alternative", "AdaptiveCardsScheme.json");
            builder.Services.AddBlazoredLocalStorage();

            await builder.Build().RunAsync();
        }
    }
}
