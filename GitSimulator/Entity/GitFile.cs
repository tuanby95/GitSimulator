namespace GitSimulator.Entity
{
    public class GitFile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Version { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CommitId { get; set; }
        public HashSet<GitFile> Versions { get; set; }
        public Commit Commit { get; set; }

        public GitFile()
        {
            Versions = new HashSet<GitFile>();
            Commit = new Commit();
        }
    }
}
