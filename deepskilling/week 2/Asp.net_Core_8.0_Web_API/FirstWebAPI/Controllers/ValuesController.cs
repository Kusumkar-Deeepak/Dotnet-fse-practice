using FirstWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    private static readonly List<ValueItem> Values =
    [
        new(1, "Iphone"),
        new(2, "Samsung"),
        new(3, "Redmi")
    ];

    private static int nextId = Values.Count + 1;

    // GET: api/values
    [HttpGet]
    public ActionResult<IEnumerable<ValueItem>> GetAll()
    {
        return Ok(Values);
    }

    // GET: api/values/5
    [HttpGet("{id:int}")]
    public ActionResult<ValueItem> GetById(int id)
    {
        var value = Values.FirstOrDefault(item => item.Id == id);
        return value is null ? NotFound() : Ok(value);
    }

    // POST: api/values
    [HttpPost]
    public ActionResult<ValueItem> Create([FromBody] ValueUpsertRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
        {
            return BadRequest("Name is required.");
        }

        var createdValue = new ValueItem(nextId++, request.Name.Trim());
        Values.Add(createdValue);

        return CreatedAtAction(nameof(GetById), new { id = createdValue.Id }, createdValue);
    }

    // PUT: api/values/5
    [HttpPut("{id:int}")]
    public ActionResult<ValueItem> Update(int id, [FromBody] ValueUpsertRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
        {
            return BadRequest("Name is required.");
        }

        var existingIndex = Values.FindIndex(item => item.Id == id);
        if (existingIndex < 0)
        {
            return NotFound();
        }

        var updatedValue = Values[existingIndex] with { Name = request.Name.Trim() };
        Values[existingIndex] = updatedValue;

        return Ok(updatedValue);
    }

    // DELETE: api/values/5
    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var removedCount = Values.RemoveAll(item => item.Id == id);
        return removedCount == 0 ? NotFound() : NoContent();
    }
}