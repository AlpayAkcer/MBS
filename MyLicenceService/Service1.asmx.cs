using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace MyLicenceService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        public AuthHeader Kimlik;
        [WebMethod]
        [SoapHeader("Kimlik")]
        public int CheckLicence(LicencePack lp)
        {
            if (Kimlik.Login == "Admin" && Kimlik.Pwd == "123456")
            {
                LicenceDbDataContext db = new LicenceDbDataContext();
                Licence lc = db.Licences.FirstOrDefault(x => x.ProductKey == lp.ProductKey);
                if (lc != null)
                {   //Anahtar Mevcut
                    if (lc.HddNo == lp.HddNo)
                    {
                        if (lc.IsLocked == true)
                        {
                            //Key kilitli
                            return 4;
                        }
                        return 1;
                    }
                    else if (!String.IsNullOrEmpty(lc.HddNo))
                    {
                        // Bu ürün anahtarı başkasına ait.
                        
                        return 2;
                    }
                    else
                        // Kullanılmamış bir ürün anahtarı mevcut..
                        return 3;
                }
                else //Böyle bir ürün anahtarı yok
                    return 0;
            }
            // Bu istek bu programla alakalı değil..
            return 8;
        }

        [WebMethod]
        [SoapHeader("Kimlik")]
        public int RegisterLicence(LicencePack lp)
        {

            if (Kimlik.Login == "Admin" && Kimlik.Pwd == "123456")
            {
                LicenceDbDataContext db = new LicenceDbDataContext();
                Licence lc = db.Licences.FirstOrDefault(x => x.ProductKey == lp.ProductKey);
                if (lc != null)
                {
                    if (String.IsNullOrEmpty(lp.HddNo))
                    {
                        lc.HddNo = lp.HddNo;
                        lc.IsLocked = false;
                        db.SubmitChanges();
                        foreach (string macAddress in lp.MacList)
                        {
                            Mac m = new Mac();
                            m.Address = macAddress;
                            lc.Macs.Add(m);
                            db.SubmitChanges();
                        }
                        return 1;
                    }
                    return 0;
                }
                return 0;
            }
            return 0;}
    }
}