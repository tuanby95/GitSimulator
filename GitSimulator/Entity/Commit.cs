namespace GitSimulator.Entity
{
    public class Commit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public HashSet<GitFile> Files { get; set; }
        public Commit() 
        {
            Files = new HashSet<GitFile>();
        }
    }
}
