using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Web.Controllers
{
    public class ErrorController : Controller
    {
       
        [Route("Error/{statusCode}")]
        public IActionResult HandleErrorCode(int statusCode)
        {

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sayfa bulunamadı";
                    ViewBag.Code = statusCode;
                    break;

                case 500:
                    ViewBag.ErrorMessage = "Sunucu hatası";
                    ViewBag.Code = statusCode;
                    break;
            }
           
            return View();
        }

    }
}
       


       





           

