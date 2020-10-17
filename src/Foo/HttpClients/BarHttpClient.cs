using System.Net.Http;
using System.Threading.Tasks;

namespace Foo.HttpClients
{
    public class BarHttpClient : IBarHttpClient
    {
        private readonly HttpClient _httpClient;

        public BarHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetBarAsync() =>
            await _httpClient.GetStringAsync("/bar");
    }
}
