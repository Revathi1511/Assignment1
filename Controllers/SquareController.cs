using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmentweek1.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/Square/{id}
        public IEnumerable<int> Get(int id)
        {
            double result = Math.Pow(id, 2);
            return new int[] { (int)result };
        }

    }
}
