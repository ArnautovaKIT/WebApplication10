using WebApplication10.model;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication10.Controles
{
    [Route("api/[controller]")]
    [ApiController]
    public class Productsimportcontrolller : ControllerBase //это мы делаем
    {
        public AppDbContext _contetx { get; set; } // это мы делаем
        public Productsimportcontrolller(AppDbContext contetx) //это мы делаем
        {
            _contetx = contetx;
        }// это мы делаем


        // GET: api/<Productsimport>
        [HttpGet]
        public ActionResult<IEnumerable<Productsimport>> Get()   // модель 
        {
            var reuslt = _contetx.productsimport.ToList();
            return Ok(reuslt);
        }

        // GET api/<Productsimport>/5
        [HttpGet("{id}")]
        public ActionResult Getid(int id)
        {
            var reuslt = _contetx.productsimport.Find(id);
            if (reuslt == null)
            {
                return NotFound();
            }// проверка

            return Ok(reuslt);
        }

        // POST api/<Productsimport>
        [HttpPost]
        public IActionResult Post([FromBody] Productsimport values)
        {
            _contetx.productsimport.Add(values);
            _contetx.SaveChanges();
            return CreatedAtAction(nameof(Getid), new { id = values.Id}, values);

        }

        // PUT api/<Productsimport>/5 //редактирование данных
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Productsimport value)
        {
            var reuslt = _contetx.productsimport.Find(id);
            if (reuslt == null)
            {
                return NotFound();
            }

            reuslt.articul = value.articul; // все поля модели так сделать по этому примерус

            _contetx.SaveChanges();
            return NoContent();
        }

        // DELETE api/<Productsimport>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reuslt = _contetx.productsimport.Find(id);
            if (reuslt == null)
            {
                return NotFound();
            }// проверка

            _contetx.Remove(reuslt);
            _contetx.SaveChanges();
            return NoContent();
        }
    }
}
