using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmentweek1.Controllers
{
    public class MathematicsController : ApiController
    {
        //GET api/Mathematics/{id} 
        public string Get(int id)

        {
            int result = 8 + id / id + (5 * id) - 7;

            return result.ToString();        }
    }
}
