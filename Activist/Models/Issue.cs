using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Activist.Models
{
    public class Issue {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
    public class IssueDBContext: DbContext
    {
        public DbSet<Issue> Issues{get;set;}
    }
}
