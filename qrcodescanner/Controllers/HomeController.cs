using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aspose.BarCode.BarCodeRecognition;
using qrcodescanner.Models;

namespace qrcodescanner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ResimGoruntule(ResimGoruntuleViewModel model)
        {

            if (model.Resim.Contains(".jpg") || model.Resim.Contains(".jpeg") || model.Resim.Contains(".JPG") || model.Resim.Contains(".JPEG") || model.Resim.Contains(".png"))
            {
                return View(model);
            }
           return new JsonResult();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hakkımızda";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim";

            return View();
        }
    }
}