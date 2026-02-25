namespace WebApplication10.model
{
    public class partnetu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; } 

        public int inn { get; set; } 
        public int phont { get; set; } 
        public string email { get; set; }
         public string locaciaproduct { get; set; } 

        public List<Orders> Orderss { get; set; }  
            

    }
}
