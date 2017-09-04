using System.Collections.Generic;
using NsExcel = Microsoft.Office.Interop.Excel;

namespace ExportList
{
    class ExcelList
    {
        /// <summary>
        /// Export a list to Excel.
        /// </summary>
        /// <param name="list">List to export.</param>
        public void ListToExcel(List<string> list)
        {
            // Start Excel application.
            var excelApp = new NsExcel.Application();
            // Option to show Excel.
            excelApp.Visible = true;

            // Add new workbook to Excel.
            var workbook = excelApp.Workbooks.Add(NsExcel.XlWBATemplate.xlWBATWorksheet);
            var sheet = (NsExcel.Worksheet) workbook.Sheets[1];
            string cellName;
            int counter = 1;
            foreach (var item in list)
            {
                cellName = "B" + counter.ToString();
                var range = sheet.get_Range(cellName, cellName);
                range.Value2 = item.ToString();
                ++counter;
            }
        }
    }
}
