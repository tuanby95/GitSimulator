namespace GitSimulator.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public Organization Organization { get; set; }
        public HashSet<RepoTeam> RepoTeams { get; set; }
        public HashSet<TeamUser> TeamUsers { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<User> Members { get; set; }
        public Team ParentTeam { get; set; }
        public bool IsParentTeam { get; set; }
        public bool IsPublic { get; set; } = true;
        public Team()
        {
            Organization = new Organization();
            RepoTeams = new HashSet<RepoTeam>();
            TeamUsers = new HashSet<TeamUser>();
        }
    }
}