namespace GitSimulator.Entity
{
    public class Commit
    {
        public int Id { get; set; }
        public string? CommitName { get; set; }
        public Branch Branch { get; set; }
        public PullRequest PullRequest { get; set; }
        public HashSet<GitFile> Files { get; set; }
        public Commit() 
        {
            PullRequest = new PullRequest();
            Files = new HashSet<GitFile>();
            Branch= new Branch();
        }
    }
}
