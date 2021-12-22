using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace MusteriBilgiSistemi.Common
{
    public class Tools
    {
        public static string GetHddNo()
        {
            string hddID = null;
            ManagementClass mc = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject strt in moc)
            {
                hddID += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return hddID.Trim().ToString();
        }

        public static List<string> GetMacList()
        {
            List<string> macList = new List<string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces, thereby ignoring any
                // loopback devices etc.
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet) continue;
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macList.Add(nic.GetPhysicalAddress().ToString().Trim());

                }
            }
            macList.RemoveAll(x => x == string.Empty);
            return macList;
        }
        public static string SaveProducts(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 8) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }

        public static string SaveLogo(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/Logo/";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 8) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }

        public static string SaveNews(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/NewsPicture/";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 8) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }

        public static string SaveMakaleler(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/Makaleler/";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 8) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }

        public static string SaveSlider(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/SliderPicture/";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 8) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }

        public static string SaveCategory(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/CategoryPicture/";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 8) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }

        public static string SaveDosya(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/Files/no_image.png";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 9) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }

        public static string SaveKurumsal(FileUpload fu, string fileName)
        {
            string retval = "";
            try
            {
                string path = "~/Products/Kurumsal/";
                string newfileName = Guid.NewGuid().ToString().ToUpper().Substring(0, 9) +
                                     System.IO.Path.GetExtension(fileName);
                path += newfileName;

                // System.Web.HttpContext.Current.Server.MapPath()
                fu.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));
                retval = path;
            }
            catch (Exception)
            {
                retval = "~/Products/no_image.png";
            }
            return retval;
        }


    }
}
