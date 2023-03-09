using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public HashSet<Branch> SubBranches { get; set; }
        public HashSet<GitFile> Files { get; set; }
        public HashSet<Commit> Commits { get; set; }

        public Branch()
        {
            SubBranches = new HashSet<Branch>();
            Files = new HashSet<GitFile>();
            Owner = new User();
        }
    }
}
