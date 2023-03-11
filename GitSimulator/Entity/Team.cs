namespace GitSimulator.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public string? TeamName { get; set; }
        public Organization Organization { get; set; }
        public HashSet<RepoTeam> RepoTeams { get; set; }
        public HashSet<TeamUser> TeamUsers { get; set; }
        public Team()
        {
            Organization = new Organization();
            RepoTeams = new HashSet<RepoTeam>();
            TeamUsers = new HashSet<TeamUser>();
        }
    }
}