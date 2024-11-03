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
    public class MemberService : IMemberService
    {
        private readonly IUnitOfWork uow;
        public MemberService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<Members> GetMembers()
        {
            return uow.Member.GetAll(includeProperty: "SocialMedias");
        }
    }
}
