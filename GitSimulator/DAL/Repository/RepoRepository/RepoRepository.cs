using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL.Repository.RepoRepository
{
    public class RepoRepository : GenericRepository<Repo>, IRepoRepository
    {
        public RepoRepository(GitContext context) : base(context)
        {
        }
    }
}
