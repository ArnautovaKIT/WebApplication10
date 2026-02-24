namespace WebApplication10.model
{
    public class Producttypeimport
    {
        public int Id { get; set; }
        public string tipproducts { get; set; }//Тип продукции

        public int coofizent { get; set; } // Коэффициент типа продукции
        public List<Productmaterialsimport> productmaterialsimports { get; set; }
        public int zakazuId { get; set; }
        public zakazu zakazu { get; set; }
    }
}