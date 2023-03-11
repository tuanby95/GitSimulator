namespace GitSimulator.Entity
{
    public class GitFile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public DateTime CreatedTime { get; set; }
        public Commit Commit { get; set; }
        public HashSet<Branch> Branch { get; set; }
        public HashSet<GitFile> FileVersions { get; set; }
        public HashSet<BranchFile> BranchFiles { get; set; }

        public GitFile()
        {
            Commit = new Commit();
            Branch = new HashSet<Branch>();
            FileVersions = new HashSet<GitFile>();
            BranchFiles = new HashSet<BranchFile>();
        }
    }
}
