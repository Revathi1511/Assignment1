using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmentweek1.Controllers
{
    public class AddtenController : ApiController
    {
        // GET api/AddTen/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 };
        }
    }
}
