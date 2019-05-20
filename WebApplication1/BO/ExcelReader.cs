using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Excel = Microsoft.Office.Interop.Excel;
namespace WebApplication1.BO
{
    public class ExcelReader
    {

        public static List<string> ReadExcel(string filePath)
        {
            List<string> excelValues = new List<string>();

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 3; i <= rowCount; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 1; j <= 3; j++)
                {
                    sb.AppendFormat(" {0}", xlRange.Cells[i, j].Text.ToString());
                }

                excelValues.Add(sb.ToString());
            }

            return excelValues;

        }


    }
}