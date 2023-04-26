using CurrencyQuotationMinimal.Api.Config;
using CurrencyQuotationMinimal.Api.Services.Concrats;
using Refit;

namespace CurrencyQuotationMinimal.Api.StartUp
{
    public static class Refit
    {
        public static void AddRefit(this IServiceCollection services)
        {  // comment
            var serviceProvider = services.BuildServiceProvider();
            var appConfig = serviceProvider.GetService<IConfiguration>().GetSection("QuotationApi").Get<AppConfigSettings>();

            services
           .AddRefitClient<IQuotationApi>()
           .ConfigureHttpClient(c => c.BaseAddress = new Uri(appConfig.ApiUrl));
        }
    }
}
