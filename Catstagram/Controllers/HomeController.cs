using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Catstagram.Controllers;

public class HomeController : ApiController
{
    [Authorize]
    public IActionResult Get()
    {
        return Ok("Works");
    }
}

