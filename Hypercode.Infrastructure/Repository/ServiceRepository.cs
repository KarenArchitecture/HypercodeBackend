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
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        private readonly ApplicationDbContext context;
        public ServiceRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public bool Update(Service entity)
        {
            try
            {
                context.Services.Update(entity);
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
