using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers;

[ApiController]
[Route("[controllers]")]
public class UsersController : Controller
{
    public UsersController()
    {
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<IActionResult> Get()
    {
        return null;
    }
}