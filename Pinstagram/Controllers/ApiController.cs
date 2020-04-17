using Microsoft.AspNetCore.Mvc;

namespace Pinstagram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
