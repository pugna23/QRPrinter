using QRPrinter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BO;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Print");
        }

        public ActionResult Print()
        {
            List<string> values;
            using (QR_Data dbContext = new QR_Data())
            {
                values = dbContext.qrData.Select(x => (x.EAB + " " + x.Local + " " + x.Med)).ToList();
            }

            var model = new PrintsViewModel();

            for (int i = 0; i < 4; i++)
            {
                foreach (var print in values)
                {
                    model.Prints.Add(new Print(print));
                }
            }

            foreach (var print in model.Prints)
            {
                Bitmap bm = QRGenerator.GetQRImage(print.Title);
                print.Img = QRGenerator.ImageToByte(bm);
            }
            return View(model);
        }
    }
}