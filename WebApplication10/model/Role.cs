namespace WebApplication10.model
{
    public class Role
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public List<User> users { get; set; }
    }
}
