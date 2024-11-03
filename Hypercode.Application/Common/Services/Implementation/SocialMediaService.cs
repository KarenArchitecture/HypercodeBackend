using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Services.Implementation
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IUnitOfWork uow;
        public SocialMediaService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public IEnumerable<SocialMedia> GetSocialMedias(int memberId)
        {
            return uow.SocialMedia.GetAll(u => u.MemberId == memberId);
        }
    }
}
