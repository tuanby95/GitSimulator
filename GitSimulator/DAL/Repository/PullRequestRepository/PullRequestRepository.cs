using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL.Repository.PullRequestRepository
{
    internal class PullRequestRepository : GenericRepository<PullRequest>, IPullRequestRepository
    {
        public PullRequestRepository(GitContext context) : base(context)
        {
        }
    }
}
