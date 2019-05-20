using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PrintsViewModel
    {
        public PrintsViewModel()
        {
            this.Prints = new List<Print>();
            //this.Prints = new List<Print>() {
            //    new Print("Primera"), new Print("Segunda"), new Print("Tercero"), new Print("Cuarto") , new Print("Quinto"),
            //    new Print("Primera"), new Print("Segunda"), new Print("Tercero"), new Print("Cuarto") , new Print("Quinto"),
            //    new Print("Primera"), new Print("Segunda"), new Print("Tercero"), new Print("Cuarto") , new Print("Quinto"),
            //    new Print("Primera"), new Print("Segunda"), new Print("Tercero"), new Print("Cuarto") , new Print("Quinto"),
            //    new Print("Primera"), new Print("Segunda"), new Print("Tercero"), new Print("Cuarto") , new Print("Quinto")
            //};
        }

        public List<Print> Prints { get; set; }
        public int colNum { get; set; }
    }
}