using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhoenixAPI3.Helper;

namespace PhoenixAPI3.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
[AllowAnonymous]
public class SecurityController : Controller
{
    [HttpGet]
    public string Login(string userName, string password) => JWTTokenGenerator.Generate(userName, password);

}
