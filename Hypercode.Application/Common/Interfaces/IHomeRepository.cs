using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Interfaces
{
    public interface IHomeRepository : IRepository<Home>
    {
        bool Update(Home entity);

    }
}
