﻿using Hypercode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Interfaces
{
    public interface IProjectRepository : IRepository<Project>
    {
        bool Update(Project project);
    }
}
