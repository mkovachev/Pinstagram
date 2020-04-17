using Microsoft.AspNetCore.Authorization;

namespace Pinstagram.Controllers
{
    [Authorize]
    public class HomeController : ApiController
    {
    }
}
