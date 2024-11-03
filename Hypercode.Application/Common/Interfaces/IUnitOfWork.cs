using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IProjectRepository Project { get; }
        IProjectCategoryRepository ProjectCategory { get; }
        IHomeRepository Home { get; }
        IServiceRepository Service { get; }
        ISocialMediaRepository SocialMedia { get; }
        IRoadMapRepository RoadMap { get; }
        IMemberRepository Member { get; }
        void Save();
    }
}
