
using CurrencyQuotationMinimal.Api.Config;
using CurrencyQuotationMinimal.Api.Endpoints;
using CurrencyQuotationMinimal.Api.Services;
using CurrencyQuotationMinimal.Api.Services.Concrats;
using CurrencyQuotationMinimal.Api.StartUp;

namespace CurrencyQuotationMinimal.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.Configure<AppConfigSettings>(builder.Configuration.GetSection("QuotationApi"));
            builder.Services.AddScoped<IHttpClientQuotationService, HttpClientQuotationService>();
            builder.Services.AddRefit();

            var app = builder.Build();

          
                app.UseSwagger();
                app.UseSwaggerUI();
          

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapQuotationEndpoints();

            app.Run();
        }
    }
}