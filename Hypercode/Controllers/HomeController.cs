using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Domain.Entities;
using Hypercode.Models;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hypercode.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService service;
        private readonly IProjectService project_service;
        private readonly ISocialMediaService socialMedia_service;
        private readonly IMemberService member_service;
        private readonly IRoadMapService roadMap_service;
        
        
        public HomeController(IHomeService service, IProjectService project_service, ISocialMediaService socialMedia_service)
        {
            this.service = service;
            this.project_service = project_service;
            this.socialMedia_service = socialMedia_service;
            
        }
        public IActionResult Index(int proCatId)
        {
            if (proCatId == 0)
            {
                proCatId = 1;
            }

            HomeVM vm = new HomeVM()
            {
                Home = service.GetHome(),
                Projects = project_service.GetAllProjects(proCatId),
                Categories = project_service.GetProjectCategories()
            };
            return View(vm);
        }

        //[Route("Projects/{proCatId}")]
        public IActionResult GetProject(int proCatId)
        {
            return ViewComponent("Projects", new { proCatId = proCatId});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About()
        {
            AboutDescriptionVM vm = new()
            {
                AboutDescription = service.GetHome().AboutDescription
            };
            return View(vm);
        }
        public IActionResult AboutMembers()
        {
            return ViewComponent("AboutMembers");
        }
        public IActionResult Contact()
        {
            var obj = service.GetHome();
            ContactVM vm = new ContactVM()
            {
                Address = obj.Address,
                ContactLogo = obj.ContactLogo,
                ContactSlogan = obj.ContactSlogan,
                PhoneNumber = obj.PhoneNumber,
                Email = obj.Email,
                WebsiteURL = obj.WebsiteURL,
                // pass 1 to GetSocialMedias method => 1 is memberId for Home
                SocialMedias = socialMedia_service.GetSocialMedias(1)
            };
            return View(vm);
        }
    }
}
