using Employee.Functions;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;
using Employee.Services;

namespace Employee.Controllers
{

    [ApiController]
    [Route("Api/[controller]")]
    public class EmployeeController : Controller
    {

        public readonly EmployeeService _Services;
        public IConfiguration _configuration { get; set; }
        public GeneralFunction FunctionsGeneral;
        public EmployeeController(IConfiguration configuration, EmployeeService employeeService)
        {
            FunctionsGeneral = new GeneralFunction(configuration);
            _configuration = configuration;
            _Services = employeeService;
        }

        [HttpPost("Create Employee")]
        public IActionResult Create(EmployeeModel entity)
        {
            try
            {
                _Services.Add(entity);

                return Ok(new { nessage = "creado con exito" });
            }
            catch (Exception ex)
            {
                FunctionsGeneral.AddLog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("lista Employee")]
        public ActionResult<IEnumerable<EmployeeModel>> GetEmployee()
        {
            try
            {

                return Ok("listado de Employee");
            }
            catch (Exception ex)
            {
                FunctionsGeneral.AddLog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }
    }
}
