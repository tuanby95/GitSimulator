namespace GitSimulator.Entity
{
    public class Repo
    {
        public int Id { get; set; }
        public string? RepoName { get; set; }
        public DateTime CreatedTime { get; set; }
        public HashSet<Branch> Branches { get; set; }
        public User Owner { get; set; }
        public HashSet<User> Contributors { get; set; }
        public HashSet<GitFile> Files { get; set; }
        public HashSet<PullRequest>? PullRequests { get; set; }
        public HashSet<InviteRequest> InviteRequests { get; set; }

        public Repo()
        {
            Owner = new User();
            Contributors = new HashSet<User>();
            InviteRequests = new HashSet<InviteRequest>();
            Files = new HashSet<GitFile>();
            Branches = new HashSet<Branch>();
        }
    }
}
