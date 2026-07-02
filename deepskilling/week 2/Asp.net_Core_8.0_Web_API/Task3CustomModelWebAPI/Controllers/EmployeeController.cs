using Task3CustomModelWebAPI.Filters;
using Task3CustomModelWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Task3CustomModelWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private static readonly List<Employee> Employees = GetStandardEmployeeList();

    private static List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Anjali",
                Salary = 30000,
                Permanent = true,
                DateOfBirth = new DateTime(2002, 5, 15),
                Department = new Department { Id = 1, Name = "IT" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = "SQL" }
                }
            },
            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Salary = 25000,
                Permanent = false,
                DateOfBirth = new DateTime(2001, 10, 10),
                Department = new Department { Id = 2, Name = "HR" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 3, Name = "Communication" }
                }
            }
        };
    }

    // GET: api/employee
    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<List<Employee>> Get(bool throwError = false)
    {
        if (throwError)
        {
            throw new Exception("Sample error from GET action.");
        }

        return Ok(Employees);
    }

    // GET: api/employee/1
    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Employee> GetById(int id)
    {
        var employee = Employees.FirstOrDefault(item => item.Id == id);
        return employee is null ? NotFound() : Ok(employee);
    }

    // POST: api/employee
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        if (string.IsNullOrWhiteSpace(employee.Name))
        {
            return BadRequest("Employee name is required.");
        }

        employee.Id = Employees.Count + 1;
        Employees.Add(employee);
        return Ok(employee);
    }

    // PUT: api/employee/1
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
}