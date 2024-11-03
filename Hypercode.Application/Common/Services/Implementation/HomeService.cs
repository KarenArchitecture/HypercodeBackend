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
    public class HomeService : IHomeService
    {
        private readonly IUnitOfWork uow;
        public HomeService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public Home GetHome()
        {
            return uow.Home.Get(u => u.Id == 1);
        }

    }
}
