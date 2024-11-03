using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Domain.Entities
{
    public class Members
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Image { get; set; }
        public IEnumerable<SocialMedia> SocialMedias { get; set; }
    }
}
