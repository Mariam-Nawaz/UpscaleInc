using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using upscaleInc.Server.Data;
using upscaleInc.Shared;
using UpscaleInc.Shared;

namespace UpscaleInc.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ViewcommentController : Controller
    {
        private readonly appDb db;
        public ViewcommentController(appDb DB)
        {
            db = DB;
        }
        [HttpGet]
        public IEnumerable<customer_reviews> chck()
        {
            IEnumerable<customer_reviews> cust = db.customer_Reviews;
            return cust;



        }
    }
}
