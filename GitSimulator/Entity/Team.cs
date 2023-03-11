namespace GitSimulator.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public string? TeamName { get; set; }
        public HashSet<User> Members { get; set; }
        public Organization Organization { get; set; }
        public List<RepoTeam> RepoTeams { get; set; }
        public Team()
        {
            Members = new HashSet<User>();
            Organization = new Organization();
            RepoTeams = new List<RepoTeam>();
        }
    }
}