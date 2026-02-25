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
        public string family { get; set; }
        public string helth { get; set; }
       public List<Productsimport> productsimport {  get; set; }
         
    }
}
