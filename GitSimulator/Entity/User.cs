namespace GitSimulator.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public HashSet<Repo> Repositories { get; set; }
        public HashSet<Branch> Branches { get; set; }
        public HashSet<InviteRequest> InviteRequests { get; set;}
        public HashSet<Team> Team { get; set; }

        public User()
        {
            Repositories = new HashSet<Repo>();
            Branches = new HashSet<Branch>();
            InviteRequests = new HashSet<InviteRequest>();
            Team = new HashSet<Team>();
        }
    }
}
