using GitSimulator.Entity;

namespace GitSimulator.Service
{
    internal static class BranchService
    {
        //internal static Branch CreateBranch(Repository repo, User creator, string branchName, HashSet<GitFile> files)
        //{
        //    var result = new Branch();
        //    if (repo != null && repo.Branches.FirstOrDefault(e => e.Name.Equals(branchName)) is null)
        //    {
        //        repo.Branches.Add(new Branch() { Name = branchName, Owner = creator, Files = files });
        //        SaveChanges();
        //    }
        //    result = repo.Branches.FirstOrDefault(e => e.Equals(branchName));
        //    return result;
        //}

        //internal static Branch CreateSubBranch(Branch baseBranch, Branch subBranch)
        //{
        //    if (subBranch != null && baseBranch != null && baseBranch.SubBranches.FirstOrDefault(e => e.Name.Equals(subBranch.Name)) is null)
        //    {
        //        baseBranch.SubBranches.Add(subBranch);
        //        subBranch.Files = baseBranch.Files;
        //        SaveChanges();
        //    }
        //    return baseBranch.SubBranches.FirstOrDefault(e => e.Name.Equals(subBranch.Name));
        //}

        //internal static HashSet<GitFile> GetCode()
        //{
        //    throw new NotImplementedException();
        //}

        //internal static HashSet<GitFile> GetCodeByBranch(Repository repo, Branch branch)
        //{
        //    if (repo.Branches.FirstOrDefault(branch) != null)
        //    {
        //        return branch.Files;
        //    }
        //    //If branch does not exist, return code of the repo
        //    return repo.Files;
        //}

        //internal static GitFile ViewLastFile(Repository repo, Branch branch)
        //{
        //    var lastFile = new GitFile();
        //    if (repo.Branches.FirstOrDefault(e => e.Equals(branch)) != null)
        //    {
        //        lastFile = repo.Branches.FirstOrDefault(branch).Files.OrderByDescending(e => e.CreatedTime).First();
        //    }
        //    return lastFile;
        //}

        //private static void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}
    }
}