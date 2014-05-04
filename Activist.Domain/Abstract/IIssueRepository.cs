using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activist.Domain.Concrete;

namespace Activist.Domain.Abstract
{
    public class IIssueRepository
    {
        IQueryable<Issue> Issues { get; set; }
    }
}
