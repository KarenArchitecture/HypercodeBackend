using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Implementation;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hypercode.Web.Components
{
    public class HomeAboutViewComponent : ViewComponent
    {
        private readonly IHomeService service;

        public HomeAboutViewComponent(IHomeService service)
        {
            this.service = service;
        }
        public IViewComponentResult Invoke()
        {
            var obj = service.GetHome();
            HomeAboutVM vm = new HomeAboutVM()
            {
                AboutDescription = obj.AboutDescription,
                BannerImage = obj.BannerImage,
                PhoneNumber = obj.PhoneNumber
            };
            return View("HomeAbout", vm);
        }
    }
}
