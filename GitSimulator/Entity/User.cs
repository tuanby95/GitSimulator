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
        public HashSet<BranchUser> BranchUser { get; set; }
        public HashSet<RepoUser> RepoUsers { get; set; }
        public HashSet<OrgUser> OrgUsers { get; set; }
        public HashSet<TeamUser> TeamUsers { get; set; }

        public User()
        {
            RepoUsers = new HashSet<RepoUser>();
            BranchUser = new HashSet<BranchUser>();
            OrgUsers = new HashSet<OrgUser>();
            TeamUsers = new HashSet<TeamUser>();
        }
    }
}
