using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL.Repository.GitFileRepository
{
    internal class GitFileRepository : GenericRepository<GitFile>, IGitFileRepository
    {
        public GitFileRepository(GitContext context) : base(context)
        {
        }
    }
}
