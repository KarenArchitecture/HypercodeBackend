using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Implementation;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hypercode.Web.Components
{
    public class AboutMembersViewComponent : ViewComponent
    {
        private readonly IMemberService service;

        public AboutMembersViewComponent(IMemberService service)
        {
            this.service = service;
        }
        public IViewComponentResult Invoke()
        {
            var items = service.GetMembers();
            List<AboutMemberVM> vm = new List<AboutMemberVM>();
            
            foreach (var item in items)
            {
                vm.Add(new AboutMemberVM()
                    {
                        Name = item.Name,
                        Image = item.Image,
                        memberSocialMedias = item.SocialMedias,
                    }
                    );
            }

            return View("AboutMembers", vm);
        }
    }
}
