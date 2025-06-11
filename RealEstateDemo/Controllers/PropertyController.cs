using Microsoft.AspNetCore.Mvc;
using RealEstateDemo.DataAccess;
using RealEstateDemo.ViewModels;

namespace RealEstateDemo.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            var properties = Property.GetPropertiesByCityFK(10)
                .Select(p => PropertyIndexViewModel.ToViewModel(p))
                .ToList();

            return View(properties);
        }
    }
}
