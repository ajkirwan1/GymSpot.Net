using GymSpot.Areas.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.ViewComponents

{
    [ViewComponent]
    public class GridsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(UserGridModel? gridModel)
        {
            // ViewBag.UserList = model;
            return View("Sample", gridModel); //invoked a partial view from Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
