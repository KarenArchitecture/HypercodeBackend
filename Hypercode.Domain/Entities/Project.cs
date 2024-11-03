using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime FinishedDate { get; set; }
        // [NotMapped]
        public string? Image { get; set; }
        public string? URL { get; set; }
        [Length(30,100)]
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        [Required] [ForeignKey("ProjectCategory")]
        public int ProjectCategoryId { get; set; }
        [ValidateNever]
        public ProjectCategory ProjectCategory { get; set; }

    }
}
