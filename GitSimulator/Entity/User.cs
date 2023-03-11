namespace GitSimulator.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public HashSet<Repo>? Repositories { get; set; }
        public HashSet<Branch>? Branches { get; set; }
        public HashSet<InviteRequest>? InviteRequests { get; set;}
        public HashSet<PullRequest>? PullRequests { get; set; }
        public HashSet<Team>? Team { get; set; }
        public HashSet<Organization>? Organizations { get; set; }
        public List<RepoUser> RepoUsers{ get; set; }
    }
}
