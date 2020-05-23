using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetNumber()
        {
            return new string[] {"value1", "value2"};
        }
    }
}

// using Microsoft.AspNetCore.Mvc;

// namespace TodoApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class ValuesController : ControllerBase
//     {

//         // GET: api/TodoItems
//         [HttpGet]
//         public ActionResult<IEnumerable<string>> Get()
//         {
//             return new string[] { "value1", "value2" };
//         }
//     }
// }
