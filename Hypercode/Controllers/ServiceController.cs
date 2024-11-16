using Hypercode.Application.Common.Services.Interface;
using Hypercode.Application.Common.Utility;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hypercode.Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService service;
        public ServiceController(IServiceService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var serviceItems = service.GetAllServices();
            List<ServiceVM> list = new List<ServiceVM>();
            foreach (var item in serviceItems)
            {
                var vm = new ServiceVM()
                {
                    ServiceId = item.Id,
                    Description = item.Description,
                    Icon = item.Icon,
                    Name = item.Name
                };
                list.Add(vm);
            }
            return View(list);
        }
        public IActionResult Single(int serviceId)
        {
            var obj = service.GetService(serviceId);
            ServiceVM vm = new ServiceVM()
            {
                FullDescription = obj.Description,
                Icon = obj.Icon,
                Name = obj.Name
            };
            return View(vm);
        }
    }
}
