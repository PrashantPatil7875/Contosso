using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Dynamcis365Service.Models;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;


namespace Dynamcis365Service.Services
{
    public class CreateLeadService
    {
        #region Declarartions
        IOrganizationService service;

        string ORGURI = WebConfigurationManager.AppSettings["ORGURI"];
        string USERNAME = WebConfigurationManager.AppSettings["USERNAME"];
        string PASSWORD = WebConfigurationManager.AppSettings["PASSWORD"];

        internal Guid CreateLead(LeadModel lead)
        {
            service = new CRMHelper().ConnectToMSCRM(USERNAME, PASSWORD, ORGURI);
            return service.Create(new Entity("lead"));
        }
        #endregion
       
    }
}