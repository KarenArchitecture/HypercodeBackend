using Hypercode.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hypercode.Web.ViewModels
{
    public class ServiceArchiveVM
    {
        public IEnumerable<Service> services { get; set; }
    }
    public class SingleServiceVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Icon { get; set; }
    }
}
