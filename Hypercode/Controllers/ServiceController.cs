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
            ServiceArchiveVM vm = new ServiceArchiveVM();
            vm.services = service.GetAllServices();
            
            return View(vm);
        }
        public IActionResult Single(int serviceId)
        {
            var obj = service.GetService(serviceId);
            SingleServiceVM vm = new SingleServiceVM()
            {
                Description = obj.Description,
                Icon = obj.Icon,
                Name = obj.Name
            };
            return View(vm);
        }
    }
}
