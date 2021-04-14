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
            using (Stream inputStream = File.OpenRead(path))
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
        }
    }
}
