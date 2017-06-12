using MusicWebAPI.TokenAuthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicWebAPI.Controllers
{
    public class IpController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return TokenManager.GetIP(Request);
        }
    }
}