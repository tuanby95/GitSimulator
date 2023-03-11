namespace GitSimulator.Entity
{
    public class GitFile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public DateTime CreatedTime { get; set; }
        public HashSet<GitFile> FileVersions { get; set; }
        public Commit Commit { get; set; }

        public GitFile()
        {
            FileVersions = new HashSet<GitFile>();
            Commit = new Commit();
        }
    }
}
