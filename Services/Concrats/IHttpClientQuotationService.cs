using CurrencyQuotationMinimal.Api.Models;

namespace CurrencyQuotationMinimal.Api.Services.Concrats
{
    public interface IHttpClientQuotationService
    {
        Task<IDictionary<string, Currency>> GetAsync(string currencies);
    }
}
