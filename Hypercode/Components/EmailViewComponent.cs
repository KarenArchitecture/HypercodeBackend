using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Implementation;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Domain.Entities;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;



namespace Hypercode.Web.Components
{
    public class EmailViewComponent : ViewComponent
    {
        private readonly IEmailService service;

        public EmailViewComponent(IEmailService service)
        {
            this.service = service;
        }
        public IViewComponentResult Invoke()
        {

            return View("Email");
        }
        //[HttpPost]
        //public async Task<IActionResult> SaveEmail([FromBody] Email email)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        service.AddEmail(email);
        //        return new JsonResult(new { Status = "Success", Message = "Form submitted successfully" });
        //    }
        //    return new JsonResult(new { Status = "Error", Message = "Invalid data" });
        //}
    }
}
