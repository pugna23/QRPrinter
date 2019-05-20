using QRPrinter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Print
    {
        public Print(IPrintable qrData)
        {
            Initialize(qrData.ToQR);
        }

        private void Initialize(string title)
        {
            Title = title;
            Img = QRGenerator.GenerateImg(title);
        }

        public string Title { get; set; }
        public byte[] Img { get; set; }
    }
}