using Microsoft.AspNetCore.Mvc;
using Task2SwaggerWebAPI.Models;

namespace Task2SwaggerWebAPI.Controllers;

[ApiController]
[Route("api/Emp")]
public class EmployeeController : ControllerBase
{
    private static readonly List<Employee> Employees =
    [
        new Employee { Id = 1, Name = "Anjali", Department = "IT" },
        new Employee { Id = 2, Name = "Rahul", Department = "HR" }
    ];

    // GET: api/Emp
    [HttpGet(Name = "GetEmployees")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(Employees);
    }

    // GET: api/Emp/1
    [HttpGet("{id:int}", Name = "GetEmployeeById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Employee> GetById(int id)
    {
        var employee = Employees.FirstOrDefault(item => item.Id == id);
        return employee is null ? NotFound() : Ok(employee);
    }

    // POST: api/Emp
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        if (string.IsNullOrWhiteSpace(employee.Name))
        {
            return BadRequest("Name is required.");
        }

        employee.Id = Employees.Count + 1;
        Employees.Add(employee);
        return CreatedAtRoute("GetEmployeeById", new { id = employee.Id }, employee);
    }

    // PUT: api/Emp/1
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
    {
        var index = Employees.FindIndex(item => item.Id == id);
        if (index < 0)
        {
            return NotFound();
        }

        employee.Id = id;
        Employees[index] = employee;
        return Ok(employee);
    }

    // DELETE: api/Emp/1
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var removed = Employees.RemoveAll(item => item.Id == id);
        return removed == 0 ? NotFound() : Ok($"Employee {id} deleted.");
    }
}