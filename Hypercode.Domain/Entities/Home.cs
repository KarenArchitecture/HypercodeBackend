using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Domain.Entities
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(50)]
        public string HeaderPreSlogan { get; set; }
        [Required]
        [MaxLength(60)]
        public string HeaderSlogan { get; set; }
        [Required]
        public string BannerImage { get; set; }

        // Contact Page

        [Required] 
        public string PhoneNumber { get; set; }
        [Required] 
        public string Email { get; set; }
        [Required] 
        public string Address { get; set; }
        [Required] 
        public string ContactLogo { get; set; }
        [Required]
        public string ContactSlogan { get; set; }
        [Required] 
        public string WebsiteURL { get; set; }

        // About Page

        public string? AboutDescription { get; set; }


    }
}
