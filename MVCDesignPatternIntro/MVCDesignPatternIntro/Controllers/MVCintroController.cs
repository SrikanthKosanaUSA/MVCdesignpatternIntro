using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDesignPatternIntro.Models;

namespace MVCDesignPatternIntro.Controllers
{
    public class MVCintroController : Controller
    {
        //
        // GET: /MVCintro/
       [HttpGet]
        public ActionResult Index()
        {
            string UserID = Request.QueryString["userid"];

          UserData objUser = new UserData(Convert.ToInt32 (UserID));
          ViewBag.LastName = objUser.LastName;
           
           ViewBag.UserID = UserID;
 
           return View();
        }
       [HttpPost]
       public ActionResult Index(FormCollection myCollection)
       {
           string LastName = myCollection["txtLastName"];
           string btnSubmitValue = myCollection["btnSubmit"];
           string btnDeleteValue = myCollection["btnDelete"];
           
           int UserID = Convert.ToInt16 (myCollection["UserID"]);

           if (btnSubmitValue == "btnSubmit")
           {        // some operation or alternative view()
           }
           else if (btnDeleteValue == "btnDelete")
           {        // some operation or alternative view()
           }

            return View();
       }

    }
}
