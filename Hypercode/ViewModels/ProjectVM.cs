using Hypercode.Domain.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hypercode.Web.ViewModels
{
    public class ProjectVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FinishedDate { get; set; }
        public string? Image { get; set; }
        public string? URL { get; set; }
        public string? Description { get; set; }
        public string ProjectCategoryName { get; set; }
    }
}
