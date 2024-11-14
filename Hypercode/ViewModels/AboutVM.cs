using Hypercode.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hypercode.Web.ViewModels
{
    public class AboutDescriptionVM
    {
        public string AboutDescription { get; set; }
    }
    public class AboutMemberVM
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<AboutMemberSocialMediaVM> memberSocialMedias { get; set; }
    }
    public class AboutMemberSocialMediaVM
    {
        public string? SocialURL { get; set; }
        public string Icon { get; set; }
    }

}
