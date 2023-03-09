using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    public class GitFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public DateTime CreatedTime { get; set; }
        public HashSet<GitFile> Versions { get; set; }

        public GitFile()
        {
            Versions = new HashSet<GitFile>();
        }
    }
}
