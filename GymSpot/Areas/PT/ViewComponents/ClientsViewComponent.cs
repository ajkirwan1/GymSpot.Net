using GymSpot.Areas.PT.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.PT.ViewComponents;

public class ClientsViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(UserModel client)
    {
        return View("Client", client); //invoked a partial view from Views/Shared/Components/Clients/Clients.cshtml
    }
}
