namespace GitSimulator.Entity
{
    public class InviteRequest
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }
        public User Receiver { get; set; }
        public Repo Repository { get; set; }
        public InviteRequest()
        {
            Repository = new Repo();
            Receiver = new User();
        }
    }
}