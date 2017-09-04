using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportList
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = new List<string>
            {
                "firstElement",
                "secondElement",
                "thirdElement"
            };

            var listToExport = new ExcelList();
            listToExport.ListToExcel(newList);
        }
    }
}
