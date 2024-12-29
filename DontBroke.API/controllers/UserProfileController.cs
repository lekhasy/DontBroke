using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace DontBroke.API.Controllers;

[ApiController]
[Route("api/user-profile")]
public class UserProfileController : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("User Profile");
    }
}
