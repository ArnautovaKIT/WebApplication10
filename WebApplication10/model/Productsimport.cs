using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplication10.model
{
    public class Productsimport
    {
        public int  Id { get; set; }
        public string tipproduczuu { get; set; }
        public string name { get; set; }
        public int articul {  get; set; }
        public int stoumost {  get; set; }
        public int hurina { get; set; }
        public int ProductmaterialsimportId { get; set; }
        public Productmaterialsimport productmaterialsimport { get; set; }

        public int cotrydnikiId {  get; set; }
        public cotrydniki cotrydniki { get; set; }
        List<zakazu> zakazus { get; set; }
    }
}
