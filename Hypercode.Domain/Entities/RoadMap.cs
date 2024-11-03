using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Domain.Entities
{
    public class RoadMap
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1395, 1450)]
        public int Year { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
