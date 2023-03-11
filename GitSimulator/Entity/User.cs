namespace GitSimulator.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public HashSet<Repo>? Repositories { get; set; }
        public HashSet<Branch>? Branches { get; set; }
        public HashSet<InviteRequest>? InviteRequests { get; set; }
        public HashSet<PullRequest>? PullRequests { get; set; }
        public HashSet<Team>? Team { get; set; }
        public HashSet<Organization>? Organizations { get; set; }
        public List<BranchUser> BranchUser { get; set; }
        public List<RepoUser> RepoUsers { get; set; }
        public List<OrgUser> OrgUsers { get; set; }
        public List<TeamUser> TeamUsers { get; set; }

        public User()
        {
            RepoUsers = new List<RepoUser>();
            BranchUser = new List<BranchUser>();
            OrgUsers = new List<OrgUser>();
            TeamUsers = new List<TeamUser>();
        }
    }
}
