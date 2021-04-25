using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class RESTSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpclient;

        public RESTSpaceXDataService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<LaunchDto[]> GetAllLaunches()
        {
            return await _httpclient.GetFromJsonAsync<LaunchDto[]>("/rest/launches");
        }
    }
}