using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Implementation;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hypercode.Web.Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        private readonly IProjectService service;

        public ProjectsViewComponent(IProjectService service)
        {
            this.service = service;
        }
        public IViewComponentResult Invoke(int proCatId)
        {
            ProjectArchiveVM vm = new ProjectArchiveVM()
            {
                Categories = service.GetProjectCategories(),
                Projects = service.GetAllProjects(proCatId)
            };

            return View("Projects", vm);
        }
    }
}
