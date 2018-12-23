using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kontroleri_I_Akcije.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi
        public string Pozdrav()
        {
            return "Pozdrav sa prvog kontrolera";
        }


        public string KontekstniPodaci()
        {
            string serverName = Server.MachineName;
            DateTime datestamp = HttpContext.Timestamp;
            return "<h2> Kontekstni podaci iz zahtjeva: <h2>" +
                "<ul>" + "<li>" + serverName + "</li>" + "<li>" + datestamp.ToString() + "</li>" + "</ul>";
        }
    }
}