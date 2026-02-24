using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplication10.model
{
    public class Materialsimport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int zena { get; set; } //Цена единицы материала
        public int colihectdo { get; set; } // Количество на складе
        public int mun {  get; set; } //  Минимальное количество
        public int upocovok {  get; set; } //Количество в упаковке
         public int MaterId { get; set; }
        public Materialtypeimport Materialtypeimport { get; set; }
        
    }
}
