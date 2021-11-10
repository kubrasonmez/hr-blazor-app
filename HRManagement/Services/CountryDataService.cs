using HRManagement.Services.Interfaces;
using HRManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HRManagement.Services
{
    public class CountryDataService : ICountryDataService
    {
        private readonly HttpClient _httpClient;

        public CountryDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Country>>(
                await _httpClient.GetStreamAsync($"api/country"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task<Country> GetCountryById(int countryId)
        {
            throw new NotImplementedException();
        }
    }
}
