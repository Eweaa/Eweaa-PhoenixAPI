using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PhoenixAPI3.Interfaces;
using PhoenixAPI3.Models;

namespace PhoenixAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly IPatientRepo _patient;
        public PatientController(IPatientRepo patient)
        {
            _patient = patient;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AppUser>))]
        public IActionResult GetPatients()
        {
            var patients = _patient.GetPatients();
            return Ok(patients);
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AppUser>))]
        [ProducesResponseType(400)]
        public IActionResult GetPatient(int Id)
        {
            var patient = _patient.GetPatient(Id);
            return Ok(patient);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreatePatient(AppUser patient)
        {
            if (patient == null)
                return BadRequest(ModelState);

            var patients = _patient.GetPatients().Where(P => P.Id == patient.Id).FirstOrDefault();

            if (patients != null)
            {
                ModelState.AddModelError("", "Patient Already Exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_patient.CreatePatient(patient))
            {
                ModelState.AddModelError("", "Something Went Wrong While Saving");
                return StatusCode(500, ModelState);
            }

            return Ok(patients);
        }
        [HttpPost]
        public ActionResult<int> UpdateImage([FromBody] string file, string FileName)
        {
            byte[] bytes = Convert.FromBase64String(file);
            MemoryStream stream = new MemoryStream(bytes);
            IFormFile formFile = new FormFile(stream, 0, bytes.Length, "xx", "ccc");
            var image = UploadedImage(formFile, FileName);
            return 1;
        }
        private string UploadedImage(IFormFile image, string FileName)
        {
            string uploadsFolder = Path.Combine("", @"Upload");
            string imageName = FileName + ".png";
            string filePath = Path.Combine(uploadsFolder, imageName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            image.CopyTo(fileStream);
            return imageName;
        }
    }

}
