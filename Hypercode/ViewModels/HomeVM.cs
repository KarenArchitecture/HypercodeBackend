using Hypercode.Domain.Entities;

namespace Hypercode.Web.ViewModels
{
    public class HomeVM
    {
        public Home Home { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<ProjectCategory> Categories { get; set; }
    }
}
