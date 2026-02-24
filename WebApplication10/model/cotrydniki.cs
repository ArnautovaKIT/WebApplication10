namespace WebApplication10.model
{
    public class cotrydniki
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  DateTime data { get; set; }
        public string Description { get; set; }
        public  int pasport { get; set; }
        public int recvisitu { get; set; }
        public string cemqz { get; set; }
        public string zdorovw { get; set; }
        List<Productsimport> productsimports = new List<Productsimport>();
         
    }
}
