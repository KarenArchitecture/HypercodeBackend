using Hypercode.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hypercode.Web.ViewModels
{
    public class ServiceVM
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? FullDescription { get; set; }
        public string? Icon { get; set; }
    }
}
