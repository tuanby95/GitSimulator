namespace GitSimulator.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public HashSet<User> Members { get; set; }
        public Team()
        {
            Members = new HashSet<User>();
        }
    }
}