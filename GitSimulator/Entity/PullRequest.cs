namespace GitSimulator.Entity
{
    public class PullRequest
    {
        public int Id { get; set; }
        public string? RequestName { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Owner { get; set; }
        public User Reviewer { get; set; }
        public Branch FromBranch { get; set; }
        public Branch ToBranch { get; set; }
        public Repo Repository { get; set; }
        public HashSet<Commit> Commits { get; set; }

        public PullRequest()
        {
            Repository = new Repo();
            Owner = new User();
            Reviewer = new User();
            FromBranch = new Branch();
            ToBranch = new Branch();
            Commits = new HashSet<Commit>();
        }
    }
}
