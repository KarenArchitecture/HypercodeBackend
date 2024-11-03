using Hypercode.Application.Common.Interfaces;
using Hypercode.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hypercode.Domain.Entities;
using Hypercode.Application.Common.Interfaces;

namespace Hypercode.Infrastructure.Repository
{
    public class ProjectCategoryRepository : Repository<ProjectCategory>, IProjectCategoryRepository
    {
        private readonly ApplicationDbContext context;
        public ProjectCategoryRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }


        public bool Update(ProjectCategory entity)
        {
            try
            {
                context.ProjectCategories.Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

    }
}
