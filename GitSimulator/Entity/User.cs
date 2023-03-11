namespace GitSimulator.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TeamId { get; set; }
        public HashSet<Repository> Repositories { get; set; }
        public HashSet<Branch> Branches { get; set; }
        public HashSet<InviteRequest> InviteRequests { get; set;}
        public Team Team { get; set; }

        public User()
        {
            Repositories = new HashSet<Repository>();
            Branches = new HashSet<Branch>();
            InviteRequests = new HashSet<InviteRequest>();
            Team = new Team();
        }
    }
}
