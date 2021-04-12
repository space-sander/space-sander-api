using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using space.sander.web.Domain.Catalog;
using space.sander.web.Data;
namespace space.sander.web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        public CatalogController(StoreContext db) 
        {
            _db = db;
        }
    [HttpGet]    
    public IActionResult GetItems()
    {
        return Ok(_db.Items);
    }
    [HttpGet("{id:int}")]
    public IActionResult GetItem(int id)
    {
        var item = _db.Items.Find(id);
        if (item == null)
        {
            return NotFound();
        }
        return Ok();
    }
    [HttpPost]
    public IActionResult Post(Item item)
    {
        return Created("/catalog/42", item);
    }
    [HttpPost("{id:int}/ratings")]
    public IActionResult PostRating(int id, [FromBody] Rating rating)
    {
        var item = _db.Items.Find(id);
        if (item == null){
            return NotFound();
        }

        item.AddRating(rating);
        _db.SaveChanges();

        return Ok(item);
    }
    [HttpPut("{id:int}")]
    public IActionResult PutItem(int id, [FromBody] Item item)
    {
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteItem(int id)
    {
        return Ok();
    }
    }



    
}