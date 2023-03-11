namespace GitSimulator.Entity
{
    public class Branch
    {
        public int Id { get; set; }
        public string? BranchName { get; set; }
        public User Owner { get; set; }
        public Repo Repository { get; set; }
        public HashSet<Branch> SubBranches { get; set; }
        public HashSet<GitFile> Files { get; set; }
        public HashSet<Commit> Commits { get; set; }
        public HashSet<BranchUser> BranchUsers { get; set; }

        public Branch()
        {
            Repository = new Repo();
            Owner = new User();
            SubBranches = new HashSet<Branch>();
            Files = new HashSet<GitFile>();
            Commits = new HashSet<Commit>();
            BranchUsers = new HashSet<BranchUser>();
        }
    }
}
