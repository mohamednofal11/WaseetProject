using Microsoft.AspNetCore.Mvc;
using WaseetProject.DAL.Repository.Interfaces;
using WaseetProject.DAL.Entities;

namespace WaseetProject.PL.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IGenaricRepository<Property> propertyRepository;

        public PropertyController(IGenaricRepository<Property> _propertyRepository)
        {
            propertyRepository = _propertyRepository;
        }
        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var properties=await propertyRepository.GetAllAsync(ct:ct);
            return View(properties);
        }
    }
}
