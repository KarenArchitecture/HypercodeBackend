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
    public class RoadMapService : IRoadMapService
    {
        private readonly IUnitOfWork uow;
        public RoadMapService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public IEnumerable<RoadMap> GetRoadMaps()
        {
            return uow.RoadMap.GetAll().OrderBy(u => u.Year);
        }
    }
}
