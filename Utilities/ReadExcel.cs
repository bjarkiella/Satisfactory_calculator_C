using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace Satisfactory_calculator_C.Utilities





{
    public class ReadExcel
    {
        // Class properties
        private string PathIn {get;}
        private string SheetName {get;}

        // Constructor
        public ReadExcel(string pathin, string sheetname) {
            PathIn = pathin;
            SheetName = sheetname;
        }

        // Public Method that returns a specific sheet within the excel file
        public ExcelWorksheet WorkSheet() {
            var FileInfo = new FileInfo(PathIn);
            var CurrentExcelFile = new ExcelPackage(FileInfo); 
            var WorkSheet = CurrentExcelFile.Workbook.Worksheets[SheetName];
            return WorkSheet;
        }
        
        // Some filter methods here?

    }
}