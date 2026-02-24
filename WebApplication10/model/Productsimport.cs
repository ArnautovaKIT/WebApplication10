using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplication10.model
{
    public class Productsimport
    {
        public int  Id { get; set; }
        public string typeproduct { get; set; }
        public string name { get; set; }
        public int articul {  get; set; }
        public int prise {  get; set; }
        public int width { get; set; }
        public int ProductmaterialsimportId { get; set; }
        public Productmaterialsimport productmaterialsimport { get; set; }

        public int cotrydnikiId {  get; set; }
        public cotrydniki cotrydniki { get; set; }
        List<Orders> zOrderss { get; set; }
    }
}
