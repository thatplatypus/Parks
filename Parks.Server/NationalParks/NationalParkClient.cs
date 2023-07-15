using Newtonsoft.Json;
using Parks.Contract.Models;

namespace Parks.Server.NationalParks
{
	public class NationalParkClient : INationalParkClient
	{
        private readonly HttpClient _httpClient;

        public NationalParkClient(HttpClient httpClient)
		{
            _httpClient = httpClient;
        }

        public Task<object> GetNationalParkByStateAsync(string state)
        {
            return Task.FromResult(new object());
        }

        public async Task<IEnumerable<Park>> GetNationalParksAsync()
        {
            var request = await _httpClient.GetStringAsync("parks");

            return JsonConvert.DeserializeObject<IEnumerable<Parks.Contract.Models.Park>>(request);
        }

        public async Task<object> GetNationalParksTestAsync()
        {
            return await _httpClient.GetStringAsync("parks");
        }
    }
}

