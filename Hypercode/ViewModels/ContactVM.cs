using Hypercode.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hypercode.Web.ViewModels
{
    public class ContactVM
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactLogo { get; set; }
        public string ContactSlogan { get; set; }
        public string WebsiteURL { get; set; }
        public IEnumerable<SocialMedia> SocialMedias { get; set; }


    }
}
