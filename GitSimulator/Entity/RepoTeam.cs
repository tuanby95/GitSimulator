using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    internal class RepoTeam
    {
        public int Id { get; set; }
        public int RepositoryId { get; set; }
        public Repo Repository { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public RepoTeam() 
        {
            Repository = new Repo();
            Team = new Team();
        }
    }
}
