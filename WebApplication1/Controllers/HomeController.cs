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
            var model = new PrintsViewModel();
            using (QR_Data dbContext = new QR_Data())
            {
                dbContext.qrData.ToList().ForEach(qrReg =>
                {
                    if (qrReg == null)
                        throw new ArgumentNullException(nameof(qrReg));

                    model.Prints.Add(new Print(qrReg));
                });
            }

            return View(model);
        }

    }
}