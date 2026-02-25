using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplication10.model
{
    public class Materialsimport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; } //Цена единицы материала
        public int quantity { get; set; } // Количество на складе
        public int min {  get; set; } //  Минимальное количество
        public int package {  get; set; } //Количество в упаковке
         public int MaterId { get; set; }
        public int MaterialtypeimportId { get; set; }
        public Materialtypeimport Materialtypeimport { get; set; }
        public int ProductmaterialsimportId { get; set; }
        public Productmaterialsimport productmaterialsimport { get; set; }

    }
}
