using CurrencyQuotationMinimal.Api.Models;
using CurrencyQuotationMinimal.Api.Services.Concrats;

namespace CurrencyQuotationMinimal.Api.Services
{
    public class HttpClientQuotationService : IHttpClientQuotationService
    {
        private readonly IQuotationApi _quotationApi;
        public HttpClientQuotationService(IQuotationApi quotationApi)
        {
            _quotationApi = quotationApi; 
        }
        public async Task<IDictionary<string, Currency>> GetAsync(string currencies)
        {
            var quoatation = await _quotationApi.Get(currencies);

            return quoatation;
        }
    }
}
