using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public interface ISpaceXDataService
    {
        Task<LaunchDto[]> GetAllLaunches();
    }
}