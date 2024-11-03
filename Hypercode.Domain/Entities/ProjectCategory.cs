using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypercode.Domain.Entities
{
    public class ProjectCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Project>? Project { get; set; }
    }
}
