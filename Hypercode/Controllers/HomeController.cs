using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Domain.Entities;
using Hypercode.Infrastructure.Data;
using Hypercode.Models;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Hypercode.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService service;
        private readonly IProjectService project_service;
        private readonly ISocialMediaService socialMedia_service;
        private readonly IEmailService email_service;
        private readonly IServiceService service_service;
        
        
        public HomeController(IHomeService service, IProjectService project_service, ISocialMediaService socialMedia_service, IEmailService email_service, IServiceService service_service)
        {
            this.service = service;
            this.project_service = project_service;
            this.socialMedia_service = socialMedia_service;
            this.email_service = email_service;
            this.service_service = service_service;
            
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
                Categories = project_service.GetProjectCategories(),
                Services = service_service.GetAllServices().Take(3)
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
        [Route("SendEmail")]
        public string SendEmail(string fullName, string emailAddress, string messageText)
        {
            var email = new Email()
            {
                FullName = fullName,
                Text = messageText,
                Date = DateTime.Now,
                EmailAddress = emailAddress
            };

            try
            {
                email_service.AddEmail(email);
                
                return "Form submitted successfully";
            }
            catch (Exception)
            {
                return "FUCK YOU!";
            }
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
        //[HttpPost]
        //public IActionResult Contact(Email email)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        email_service.AddEmail(email);
        //        return Json(new { Status = "Success", Message = "Form submitted successfully" });
        //    }
        //    return Json(new { Status = "Error", Message = "Invalid data" });
        //}

    }
}
