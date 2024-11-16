using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Implementation;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hypercode.Web.Components
{
    public class ServicesViewComponent : ViewComponent
    {
        private readonly IServiceService service;

        public ServicesViewComponent(IServiceService service)
        {
            this.service = service;
        }
        public IViewComponentResult Invoke(int proCatId)
        {
            var serviceItems = service.GetAllServices();
            List<ServiceVM> list = new List<ServiceVM>();
            foreach (var item in serviceItems)
            {
                var vm = new ServiceVM()
                {
                    ServiceId = item.Id,
                    Description = item.ShortDescription,                    
                    Icon = item.Icon,
                    Name = item.Name
                };
                list.Add(vm);
            }
            return View("Services", list);
        }
    }
}
