using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmentweek1.Controllers
{
    public class GreetingsController : ApiController
    {
        ////GET api/Greetings/{id} 
        public string Get(int id)
        {
            string greetingMessage = $"Greeting to {id} people";
            return greetingMessage;
        }
    }
}
