using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Services.Interface
{
    public interface IMemberService
    {
        IEnumerable<Members> GetMembers();
    }
}
