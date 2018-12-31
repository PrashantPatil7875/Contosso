using Dynamcis365Service.Models;
using Dynamcis365Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dynamcis365Service.Controllers
{
    public class LeadModelController : ApiController
    {
        CreateLeadService leadservice = new CreateLeadService();
        [HttpPost]
        public Guid Create(LeadModel lead)
        {
            try
            {
                Guid leadId = leadservice.CreateLead(lead);
                return leadId;
            }
            catch (Exception e) { throw e; }

        }
    }
}
