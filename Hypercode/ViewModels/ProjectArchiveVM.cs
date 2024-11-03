using Hypercode.Domain.Entities;

namespace Hypercode.Web.ViewModels
{
    public class ProjectArchiveVM
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<ProjectCategory> Categories { get; set; }

    }
}
