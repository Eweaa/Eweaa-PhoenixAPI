using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhoenixAPI3.Interfaces;
using PhoenixAPI3.Models;

namespace PhoenixAPI3.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private readonly IAppointment _appointment;
        public AppointmentController(IAppointment appointment)
        {
            _appointment = appointment;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Appointment>))]
        public IActionResult GetAllAppointmentsByDoctor(int Id)
        {
            var appointments = _appointment.GetAllAppointmentsByDoctor(Id);
            return Ok(appointments);
        }
        
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Appointment>))]
        public IActionResult GetAllAppointmentsByPatient(int Id)
        {
            var appointments = _appointment.GetAllAppointmentsByPatient(Id);
            return Ok(appointments);
        }

    }
}
