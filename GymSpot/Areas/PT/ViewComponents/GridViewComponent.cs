using GymSpot.Areas.PT.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymSpot.Areas.PT.ViewComponents

{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(UserGridModel? gridModel)
        {
            // ViewBag.UserList = model;
            return View("Sample", gridModel); //invoked a partial view from Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
