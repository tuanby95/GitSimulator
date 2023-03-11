namespace GitSimulator.Entity
{
    public class PullRequest
    {
        public int Id { get; set; }
        public string? RequestName { get; set; }
        public DateTime CreatedDate { get; set; }
        public HashSet<Commit> Commits { get; set; }
        public User Owner { get; set; }
        public User Reviewer { get; set; }
        public Branch FromBranch { get; set; }
        public Branch ToBranch { get; set; }

        public PullRequest()
        {
            Commits = new HashSet<Commit>();
            Owner = new User();
            Reviewer = new User();
            FromBranch = new Branch();
            ToBranch = new Branch();
        }
    }
}
