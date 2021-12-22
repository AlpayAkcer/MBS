using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLicenceService
{
    public class LicencePack
    {
        public LicencePack()
        {
            this.MacList = new List<string>();
        }
        public Guid ProductKey { get; set; }
        public string HddNo { get; set; }
        public List<string> MacList { get; set; }
    }
}