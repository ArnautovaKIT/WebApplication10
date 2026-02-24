namespace WebApplication10.model
{
    public class Orders
    {
        public int Id { get; set; }
        public List<Producttypeimport> producttypeimports { get; set; }
        public int  partnetuId { get; set; }
        public partnetu partnetu { get; set; }
    
    }
}
