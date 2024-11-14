using Hypercode.Application.Common.Interfaces;
using Hypercode.Application.Common.Services.Interface;
using Hypercode.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IProjectRepository Project { get; private set; }
        public IProjectCategoryRepository ProjectCategory { get; private set; }
        public IHomeRepository Home { get; private set; }
        public IServiceRepository Service { get; private set; }
        public ISocialMediaRepository SocialMedia { get; private set; }
        public IRoadMapRepository RoadMap { get; private set; }
        public IMemberRepository Member { get; private set;}
        public IEmailRepository Email { get; private set;}



        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            Project = new ProjectRepository(context);
            ProjectCategory = new ProjectCategoryRepository(context);
            Home = new HomeRepository(context);
            Service = new ServiceRepository(context);
            SocialMedia = new SocialMediaRepository(context);
            RoadMap = new RoadMapRepository(context);
            Member = new MemberRepository(context);
            Email = new EmailRepository(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
