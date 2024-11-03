using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Interfaces
{
    public interface IRoadMapRepository : IRepository<RoadMap>
    {
        bool Update(RoadMap roadMap);
    }
}
