using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activist.Domain.Abstract;

namespace Activist.Domain.Concrete
{
    public class EFPIssueRepository : IIssueRepository{
        private EFDbContext context  = new EFDbContext();
        public IQueryable<Issue> Isses
        {
            get { return context.Issues; }
        }
    }
}
