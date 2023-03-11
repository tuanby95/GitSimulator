namespace GitSimulator.Entity
{
    public class InviteRequest
    {
        public int Id { get; set; }
        public int RepoId { get; set; }
        public int ReceiverId { get; set; }
        public User Receiver { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }
        public Repository Repository { get; set; }
        public InviteRequest()
        {
            Repository = new Repository();
            Receiver = new User();
        }
    }
}