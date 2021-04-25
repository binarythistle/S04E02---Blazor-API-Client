using System.Threading.Tasks;
using BlazorAPIClient.DataServices;
using BlazorAPIClient.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorAPIClient.Pages
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataService SpaceXDataService {get; set;}

        private LaunchDto[] launches; 

        protected override async Task OnInitializedAsync()
        {
            launches = await SpaceXDataService.GetAllLaunches();
        }   
    }
}