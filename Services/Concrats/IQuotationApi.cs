using CurrencyQuotationMinimal.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace CurrencyQuotationMinimal.Api.Services.Concrats
{
    public interface IQuotationApi
    {
        [Get("/last/{currencies}")]
        Task<IDictionary<string, Currency>> GetCurrencies(string currencies);
    }
}
