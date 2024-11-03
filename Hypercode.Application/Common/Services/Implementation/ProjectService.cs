using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Services.Implementation
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork uow;

        public ProjectService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public IEnumerable<Project> GetAllProjects(int? proCatId = 1)
        {
            if (proCatId == 0)
            {
                proCatId = 1;
            }
            return uow.Project.GetAll(x => x.ProjectCategoryId == proCatId, includeProperty: "ProjectCategory");
        }
        public Project GetProject(int projectId)
        {
            return uow.Project.Get(u => u.Id == projectId, includeProperty: "ProjectCategory");
        }
        public IEnumerable<ProjectCategory> GetProjectCategories()
        {
            return uow.ProjectCategory.GetAll(includeProperty: "Project"); 
        }
    }
}
