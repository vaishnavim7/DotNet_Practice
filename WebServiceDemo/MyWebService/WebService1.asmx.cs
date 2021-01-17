using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebService
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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        [WebMethod]
        public string LogRunnigMethod()
        {
            System.Threading.Thread.Sleep(10000); //delay
            return "Hello World";
        }


    }

    class MyCLass : System.Web.Services.WebService
    {
        public int id
        {

            set
            {
                id = value;
            }
            get { return id; }
        }
        public string name
        {
            set
            {
                name = value;
            }
            get { return name; }
        }


    }
}
