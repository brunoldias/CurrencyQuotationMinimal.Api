using CurrencyQuotationMinimal.Api.Services.Concrats;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CurrencyQuotationMinimal.Api.Endpoints
{
    public static class QuatationEndpoints
    {
        public static void MapQuotationEndpoints(this WebApplication app)
        {
            app.Map("/Quotation/{currencies}", GetQuotation).WithName("Quotation").WithOpenApi(); 
        }

        public static async Task<IResult> GetQuotation(string currencies, IHttpClientQuotationService service)
        {
            var result = await service.GetAsync(currencies);
            return Results.Ok(result);
        }
    }
}
