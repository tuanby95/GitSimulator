using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    public class BranchFile
    {
        public int BranchId { get; set; }
        public int FileId { get; set; }
        public Branch Branch { get; set; }
        public GitFile File { get; set; }

        public BranchFile()
        {
            Branch = new Branch();
            File = new GitFile();
        }
    }
}
