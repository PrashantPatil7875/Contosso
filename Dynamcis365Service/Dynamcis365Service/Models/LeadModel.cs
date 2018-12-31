using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dynamcis365Service.Models
{
    public class LeadModel
    {
        public string Topic { get; set; }
        public string BusinessName { get; set; }
        public string Phone { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string Email { get; set; }
        public string ContactPosition { get; set; }
        public string Mobile { get; set; }
        public string AddressStreet1 { get; set; }
        public string AddressStreet2 { get; set; }
        public string AddressStreet3 { get; set; }
        public string PostCode { get; set; }

    }
}