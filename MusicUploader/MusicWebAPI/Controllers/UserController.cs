using MusicWebAPI.TokenAuthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicWebAPI.Controllers
{
    //[RESTAuthorize]
    public class UserController : Controller
    {
        private string[] _people = new string[] { "John Doe", "Amy Rose", "Harry Sam" };

        public JsonResult Find(string q)
        {
            var data = _people.Where(p => p.ToLower().Contains(q));
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}