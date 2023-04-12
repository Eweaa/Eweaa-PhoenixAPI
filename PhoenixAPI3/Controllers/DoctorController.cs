using Microsoft.AspNetCore.Mvc;
using PhoenixAPI3.Business.Interfaces;
using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DoctorController : Controller
{
    private readonly IDoctorRepo _doctor;
    public DoctorController(IDoctorRepo doctor)
    {
        _doctor = doctor;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<AppUser>))]
    public IActionResult GetDoctors()
    {
        var doctors = _doctor.GetDoctors();
        return Ok(doctors);
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<AppUser>))]
    [ProducesResponseType(400)]
    public IActionResult GetDoctor(int Id)
    {
        var doctor = _doctor.GetDoctor(Id);
        return Ok(doctor);
    }

    [HttpPost]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public IActionResult CreateDoctor([FromBody] AppUser doctor)
    {
        if (doctor == null)
            return BadRequest(ModelState);

        var doctors = _doctor.GetDoctors().Where(D => D.Id == doctor.Id).FirstOrDefault();

        if (doctors != null)
        {
            ModelState.AddModelError("", "Doctor Already Exists");
            return StatusCode(422, ModelState);
        }

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (!_doctor.CreateDoctor(doctor))
        {
            ModelState.AddModelError("", "Something went wrong while saving");
            return StatusCode(500, ModelState);
        }
        return Ok(doctor);
    }
}
