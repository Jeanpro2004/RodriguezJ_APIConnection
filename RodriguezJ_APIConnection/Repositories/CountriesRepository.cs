using Newtonsoft.Json;
using RodriguezJ_APIConnection.Modelos;

namespace RodriguezJ_APIConnection.Repositories
{
    public class CountriesRepository
    {
        private HttpClient _httpClient;

        public CountriesRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task <IEnumerable<Country>> GetCountryList()
        {
            string url = "https://restcountries.com/v3.1/all";
            var response_json = await _httpClient.GetStringAsync(url);
            List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(response_json);
            return countries;
        }
    }
}
