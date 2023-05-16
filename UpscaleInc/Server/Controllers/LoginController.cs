using Microsoft.AspNetCore.Mvc;
using upscaleInc.Server.Data;
using UpscaleInc.Shared;
using upscaleInc.Shared;

namespace UpscaleInc.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly appDb db;
        public LoginController(appDb DB)
        {
            db = DB;
        }
        [HttpPost]
        public IActionResult login(login us)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    user u1 = db.users.Where(uss => uss.email == us.email && uss.Password == us.password).ToList().FirstOrDefault();
                    if (u1 != null)
                    {
                        return new JsonResult(new { message = u1.email });
                    }
                    else
                    {
                        return new JsonResult(new { message = "user name and password not match" });
                    }
                }
                catch (Exception e)
                {
                    return new JsonResult(new { message = e });

                }

            }
            return new JsonResult(new { message = " data not saved" });
        }
    }
}
