using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Services.Interface
{
    public interface IProjectService
    {
        IEnumerable<Project> GetAllProjects(int? proCatId = 1);
        Project GetProject(int projectId);
        IEnumerable<ProjectCategory> GetProjectCategories();
    }
}
