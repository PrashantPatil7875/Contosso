using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Configuration;

namespace Dynamcis365Service.Services
{
    public class CRMHelper
    {
        #region Declarartions
        IOrganizationService service;
        string ORGURI = WebConfigurationManager.AppSettings["ORGURI"];
        string USERNAME = WebConfigurationManager.AppSettings["USERNAME"];
        string PASSWORD = WebConfigurationManager.AppSettings["PASSWORD"];
        #endregion

        public CRMHelper()
        {
            ConnectToMSCRM(USERNAME, PASSWORD, ORGURI);
        }

        public IOrganizationService ConnectToMSCRM(string userName, string password, string soapOrgServiceUri)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ClientCredentials credentials = new ClientCredentials();
                OrganizationServiceProxy proxy;
                credentials.UserName.UserName = userName;
                credentials.UserName.Password = password;
                Uri serviceUri = new Uri(soapOrgServiceUri);
                proxy = new OrganizationServiceProxy(serviceUri, null, credentials, null);
                proxy.EnableProxyTypes();
                service = (IOrganizationService)proxy;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while connecting to CRM " + ex.Message);

                Console.ReadKey();
            }

            return service;
        }
    }
}