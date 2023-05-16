using Microsoft.AspNetCore.Mvc;
using upscaleInc.Server.Data;
using upscaleInc.Shared;

namespace UpscaleInc.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class hoojaa : Controller
    {
        private readonly appDb db;
        public hoojaa(appDb DB)
        {
            db = DB;
        }
        [HttpPost]
        public IActionResult comment(customer_reviews us)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Add(us);
                    db.SaveChanges();
                    return new JsonResult(new { message = " data has been saved" });
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
