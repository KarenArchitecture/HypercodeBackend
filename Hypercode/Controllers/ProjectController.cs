using Hypercode.Application.Common.Services.Interface;
using Hypercode.Application.Common.Utility;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hypercode.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService service;
        public ProjectController(IProjectService service)
        {
            this.service = service;
        }
        public IActionResult Index(int proCatId)
        {
            //var obj = service.GetProjectCategories();
            ProjectArchiveVM vm = new ProjectArchiveVM()
            {
                Categories = service.GetProjectCategories(),
                Projects = service.GetAllProjects(proCatId)
                //projects = obj.Select(u => u.Project).Where(u => u.)
            };
            return View(vm);
        }
        public IActionResult Single(int projectId)
        {
            var project = service.GetProject(projectId);
            ProjectVM vm = new ProjectVM()
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                URL = project.URL,
                ProjectCategoryName = project.ProjectCategory.Name,
                Image = project.Image,
                FinishedDate = DateConvertor.GetPersianDate(project.FinishedDate)
            };
            return View(vm);
        }
    }
}
