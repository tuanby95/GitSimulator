namespace GitSimulator.Entity
{
    public class InviteRequest
    {
        public int Id { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }

        public InviteRequest()
        {
            Sender = new User();
            Receiver = new User();
        }
        public InviteRequest(User receiver)
        {
            Receiver = receiver;
            Status = false;
            CreateTime = DateTime.Now;
        }
    }
}