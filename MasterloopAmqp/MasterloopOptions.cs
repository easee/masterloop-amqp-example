namespace MasterloopAmqp
{
    public class MasterloopOptions
    {
        public string HostName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string PersistentSubscriptionKey { get; set; }
        public string Template { get; set; }
    }
}