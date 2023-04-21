using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        // Conversion from F to C and from C to F
        [WebMethod]
        public double ConvertTemp(double temp, string unit)
        {
            if (unit == "F")
            {
                return (temp - 32) * 5 / 9;
            }
            else if (unit == "C")
            {
                return (temp * 9 / 5) + 32;
            }
            else
            {
                return 0;
            }
        }
        //Date and time of the day

        [WebMethod]
        public string GetDate()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //List of 5 elements
        [WebMethod]
        public string[] DisplayElements(string str)
        {
            return str.Split(' ');


        }

        //RON TO EURO
        [WebMethod]
        public double ConvertRONtoEURO(double ron)
        {
            return ron * 0.21;
        }
    }
}
