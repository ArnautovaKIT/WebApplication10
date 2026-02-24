using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplication10.model
{
    public class Materialtypeimport
    {
        public int Id { get; set; }
        public string typematerial { get; set; } // тип материала
        public decimal brak { get; set; } // процент брака 
        public List<Materialsimport> Materialsimports { get; set; }
        public int ProductmaterialsimportId { get; set; }
        public Productmaterialsimport productmaterialsimport { get; set; }

    }
}