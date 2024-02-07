using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM07Feb24StateManagement.Controllers
{
    public class StateMangementOptionsController : Controller
    {
    



        public ActionResult ControllerToView()
        {

            ViewBag.vb = "ViewBag Value....";
            ViewData["vd"] = "ViewData Value....";

            return View();
        }

  public ActionResult ControllerToControllerPassData()
        {

            ViewBag.vb = "ViewBag Value....";
            ViewData["vd"] = "ViewData Value....";
            TempData["td"]= "TempData Value....";

            return RedirectToAction("ControllerToControllerView");
        }
 public ActionResult ControllerToControllerView()
        {

            return View();
        }


        public ActionResult SessionStateClientSideURL ()
        {


            return View();
        }
        [HttpPost]
        public ActionResult SessionStateClientSideURL(string UserName)
        {


            return View();
        }
  public ActionResult SessionStateClientSideHiddenVariable ()
        {


            return View();
        }
        [HttpPost]
        public ActionResult SessionStateClientSideHiddenVariable(string txtpwd)
        {


            return View();
        }
        
        public ActionResult SessionStateClientSideSetCookies ()
        {
            Response.Cookies.Add(new HttpCookie("CV","Some Value Set as Cookie"));

            return View("SessionStateClientSideCookies");
        }
 
        public ActionResult SessionStateClientSideGetCookies(int? id)
        {
            if (Request.Cookies["CV"]!=null)
            {
                ViewBag.cv = Request.Cookies["CV"].Value;


            } 

            return View();
        }




        public string SessionStateServerSideSet()
        {
            Session["SD"] = "Session Data Value";


            return "Session Data Set....";
        }

        public string SessionStateServerSideGet(int? id)
        {
            if (Session["SD"] != null)
            {
                return Session["SD"].ToString();

            }

            return "Session Data Dead....";
        }

public string AppStateServerSideSet()
        {
            HttpContext.Application ["AD"] = "Application Data Value" + DateTime.Now.ToString("dd-MMM-yyy dddd hh:mm:ss t"); ;


            return "Application Data Set....";
        }

        public string AppStateServerSideGet(int? id)
        {
            if (HttpContext.Application["AD"] != null)
            {
                return HttpContext.Application["AD"].ToString();

            }

            return "App  Data Dead....";
        }
    }
    }
    
   
