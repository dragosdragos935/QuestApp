using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data;



namespace QuesttApp2.Classes
{
    internal class ExcelExporter
    {
        Application excel;
        Workbook excelworkBook;
        Worksheet excelSheet;
        Range excelCellrange;

       


        public void filltheExcel(System.Data.DataTable dt)
        {

            /*
             ExcelExporter excelExporter = new ExcelExporter();
             excelSheet.Cells[1, 1] = "ProviderName";
             excelSheet.Cells[1, 2] = "DocumentNumber";
             excelSheet.Cells[1, 3] = "Data";
             excelSheet.Cells[1, 4] = "CostType";
             excelSheet.Cells[1, 5] = "Amount";
             excelSheet.Cells[1, 6] = "Currency";
             excelSheet.Cells[1, 7] = "ValueInRon";
             excelSheet.Cells[1, 8] = "DateCurrency";*/


            Application excelApp = new Application();
            Workbook excelWorkbook = excelApp.Workbooks.Add();
            Worksheet worksheet = excelWorkbook.ActiveSheet;


            System.Data.DataTable dataTable = dt;
            for(int col = 0; col < dataTable.Columns.Count; col++)
            {
                worksheet.Cells[1,col+1]=dt.Columns[col].ColumnName;
                Console.WriteLine(dt.Columns[col].ColumnName);

            }
            for(int row = 0;row< dataTable.Rows.Count; row++)
            {
                for(int col=0; col< dataTable.Columns.Count; col++)
                {
                    worksheet.Cells[row+2,col+1]=dt.Rows[row][col];
                    Console.WriteLine(dt.Rows[row][col]);
                }
            }



            excelWorkbook.SaveAs("C:\\Users/drago/Desktop/QuesttApp2/QuesttApp2/File.xlsx");
            Console.WriteLine("Saved succesfuly");
            excelWorkbook.Close();
            excelApp.Quit();


            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);



        }



    }
}
