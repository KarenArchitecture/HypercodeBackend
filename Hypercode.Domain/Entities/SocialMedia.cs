using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Domain.Entities
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string? SocialURL { get; set; }
        [Required]
        public string Icon { get; set; }
        [ForeignKey("Members")]
        public int? MemberId { get; set; }
        public Members? Member { get; set; }
    }
}
