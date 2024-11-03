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
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork uow;
        public ServiceService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Service GetService(int serviceId)
        {
            return uow.Service.Get(u => u.Id == serviceId);
        }
        public IEnumerable<Service> GetAllServices()
        {
            return uow.Service.GetAll();
        }
    }
}
