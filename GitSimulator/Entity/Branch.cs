namespace GitSimulator.Entity
{
    public class Branch
    {
        public int Id { get; set; }
        public string? BranchName { get; set; }
        public User Owner { get; set; }
        public HashSet<Branch> SubBranches { get; set; }
        public HashSet<GitFile> Files { get; set; }
        public HashSet<Commit> Commits { get; set; }
        public Repo Repository { get; set; }

        public Branch()
        {
            SubBranches = new HashSet<Branch>();
            Files = new HashSet<GitFile>();
            Owner = new User();
            Commits= new HashSet<Commit>();
            Repository = new Repo();
        }
    }
}
