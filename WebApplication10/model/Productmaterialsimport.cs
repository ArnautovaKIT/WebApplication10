using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplication10.model
{
    public class Productmaterialsimport
    {
        public int Id { get; set; }
        public string produczua { get; set; } // Продукция
        public string material { get; set; }// Наименование материала

        public int quantitymaterials { get; set; }// Необходимое количество материала

        public int ProducttypeimportId { get; set; }
        public Producttypeimport producttypeimport { get; set; }
    
        public List<Productsimport> productsimports { get; set; }
        public List<Materialsimport>  materialsimports { get; set; }



    }
}
