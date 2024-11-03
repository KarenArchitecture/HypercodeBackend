using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Domain.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Length(30, 100)]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        public string? Icon { get; set; }
    }
}
