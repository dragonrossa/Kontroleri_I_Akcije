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
    }
}