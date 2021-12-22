using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace MyLicenceService
{
    public class AuthHeader : SoapHeader
    {
        public string Login { get; set; }
        public string Pwd { get; set; }
    }
}