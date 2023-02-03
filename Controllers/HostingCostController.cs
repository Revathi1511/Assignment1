using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmentweek1.Controllers
{
    public class HostingCostController : ApiController
    {
        //api/HostingCost/{id} 
        public string Get(int id) {
            int noOffortlight = (id / 34) + 1;
            double chargessFN = 5.50 * noOffortlight;
            double percentage = ((chargessFN / 100) * 13);
            double totalCost = chargessFN + percentage;

            return $"{noOffortlight} fortnights at $5.50/FN= ${chargessFN} CAD \n" + $" HST13 %= ${percentage} CAD \n" + $"Total = ${totalCost} CAD";
        }
    }
}
