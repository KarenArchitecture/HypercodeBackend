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
                var newItem = new AboutMemberVM()
                {
                    Name = item.Name,
                    Image = item.Image
                };
                newItem.memberSocialMedias = new List<AboutMemberSocialMediaVM>();
                foreach (var socialMediaItem in item.SocialMedias)
                {
                    newItem.memberSocialMedias.Add(new AboutMemberSocialMediaVM()
                    {
                        Icon = socialMediaItem.Icon,
                        SocialURL = socialMediaItem.SocialURL
                    });
                }
                vm.Add(newItem);
            }
            return View("AboutMembers", vm);
        }
    }
}
