using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet_Maker_2._0
{
    class MarkingData
    {
        public DataTable markingData;
        public List<DataColumn> markingDataColumns;
        public List<String> markingDataColumnHeadings;

        public void CSVToMarkingData(string path)
        {
            
            using (Stream inputStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    IWorkbook workbook = application.Workbooks.Open(inputStream);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    markingData = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
                    markingDataColumns = markingData.Columns.Cast<DataColumn>().ToList();
                    markingDataColumnHeadings = markingDataColumns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToList();
                }
            }
            
            /*
            Microsoft.Office.Interop.Excel.Application objXL = null;
            Microsoft.Office.Interop.Excel.Workbook objWB = null;
            objXL = new Microsoft.Office.Interop.Excel.Application();
            objWB = objXL.Workbooks.Open(path);
            Microsoft.Office.Interop.Excel.Worksheet objSHT = objWB.Worksheets[1];

            int rows = objSHT.UsedRange.Rows.Count;
            int cols = objSHT.UsedRange.Columns.Count;
            DataTable dt = new DataTable();
            int noofrow = 1;

            for (int c = 1; c <= cols; c++)
            {
                string colname = objSHT.Cells[1, c].Text;
                dt.Columns.Add(colname);
                noofrow = 2;
            }

            for (int r = noofrow; r <= rows; r++)
            {
                DataRow dr = dt.NewRow();
                for (int c = 1; c <= cols; c++)
                {
                    dr[c - 1] = objSHT.Cells[r, c].Text;
                }

                dt.Rows.Add(dr);
            }
            objWB.Close();
            objXL.Quit();
            markingData = dt;
            markingDataColumns = markingData.Columns.Cast<DataColumn>().ToList();
            markingDataColumnHeadings = markingDataColumns.Cast<DataColumn>()
                         .Select(x => x.ColumnName)
                         .ToList();
            */
        }
    }
}
