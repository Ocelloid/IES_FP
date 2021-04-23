using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiOne.Controllers
{
    public class SecretController : Controller
    {
        private string[] _ds = { "{id: 0, name: \"foo\"}", "{id: 1, name: \"bar\"}" };

        [Route("/secret")]
        [Authorize]
        public string Index()
        {
            return "secret message from ApiOne";
        }

        [Route("/getall")]
        public IActionResult GetAll()
        {
            var ds = _ds;
            return Ok(new
            {
                message = ds,
            });
        }

        [Route("/getone/{ds_id}")]
        public IActionResult GetOne(int ds_id)
        {
            var ds = _ds;
            return Ok(new
            {
                message = ds[ds_id],
            });
        }

    }
}
