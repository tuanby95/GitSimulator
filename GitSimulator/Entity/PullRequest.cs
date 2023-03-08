using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    internal class PullRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public HashSet<Commit> Commits { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Owner { get; set; }
        public User Reviewer { get; set; }
        public Branch FromBranch { get; set; }
        public Branch ToBranch { get; set; }

        public PullRequest() 
        {
            Commits = new HashSet<Commit>();
        }
    }
}
