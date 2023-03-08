using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Service
{
    internal static class GitFileService
    {
        internal static int GetNumbersOfVersionFile(Branch branch, GitFile file)
        {
            int result = 0;
            if (branch != null && branch.Files.FirstOrDefault(e => e.Equals(file)) != null)
            {
                result = branch.Files.FirstOrDefault(file).Versions.Count() + 1;
            }
            return result;
        }

        internal static GitFile ViewLatestVersionFile(Branch branch, int fileID)
        {
            var result = new GitFile();
            if(branch.Files.FirstOrDefault(e => e.Id.Equals(fileID)) != null && branch != null)
            {
                result = branch.Files.FirstOrDefault(e => e.Id.Equals(fileID));
            }
            return result;
        }

        internal static GitFile ViewOlderVersionFileTest(Branch branch, GitFile file, string version)
        {
            var result = new GitFile();
            if (branch.Files.FirstOrDefault(e => e.Equals(file)) != null && branch != null)
            {
                result = branch.Files.FirstOrDefault(file).Versions.FirstOrDefault(e => e.Version.Equals(version));
            }
            return result;
        }
    }
}
