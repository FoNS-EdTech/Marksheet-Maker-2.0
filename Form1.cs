using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using CheckBox = System.Windows.Forms.CheckBox;
using Point = System.Drawing.Point;
using TextBox = System.Windows.Forms.TextBox;

namespace Marksheet_Maker_2._0
{
    public partial class Form1 : Form
    {
        List<DataSetSource> dataSetSources = new List<DataSetSource>();
        Excel.Application xlApp = new Excel.Application();
        string MarksheetsSaveLocation;
        MarkingData markingData;
        MarksheetTemplate markingTemplate;
        public Form1()
        {
            InitializeComponent();
            dataSetSources.Add(new DataSetSource { selectedColumn = dataColumnSelectionComboBox, columnNameInMarksheetName = indicateNameField, cellReferenceForDataSet = templateCellLocation });
        }
        
        private void selectMarkingInfoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                markingData = new MarkingData();
                markingData.CSVToMarkingData(fileDialog.FileName);
                markingDataLabel.Text = fileDialog.SafeFileName;
                foreach (DataSetSource dataSetSource in dataSetSources)
                {
                    dataSetSource.selectedColumn.Items.AddRange(markingData.markingDataColumnHeadings.ToArray());
                }
            }
        }

        private void chooseTemplateFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                markingTemplate = new MarksheetTemplate();
                markingTemplate.file = fileDialog.FileName;
                marksheetTemplateLabel.Text = fileDialog.SafeFileName;
                markingTemplate.fileStream = fileDialog.OpenFile();
            }
        }

        private void addFieldButton_Click(object sender, EventArgs e)
        {
            var combobox = newComboBox();
            var checkBox = newCheckBox();
            var textBox = newTextBox();
            dataSetSources.Add(new DataSetSource { selectedColumn = combobox, columnNameInMarksheetName = checkBox, cellReferenceForDataSet = textBox });
        }

        private ComboBox newComboBox()
        {
            var comboBox = new ComboBox();
            comboBox.Location = new Point(dataSetSources.Last().selectedColumn.Location.X, dataSetSources.Last().selectedColumn.Location.Y + 25);
            comboBox.Size = new Size(262, 21);
            comboBox.Visible = true;
            comboBox.Items.AddRange(dataColumnSelectionComboBox.Items.Cast<Object>().ToArray());
            Controls.Add(comboBox);
            return comboBox;
        }
        private System.Windows.Forms.CheckBox newCheckBox()
        {
            var checkBox = new CheckBox();
            checkBox.Location = new Point(dataSetSources.Last().columnNameInMarksheetName.Location.X, dataSetSources.Last().columnNameInMarksheetName.Location.Y + 25);
            checkBox.Visible = true;
            checkBox.Size = new Size(15, 14);
            Controls.Add(checkBox);
            return checkBox;
        }
        private System.Windows.Forms.TextBox newTextBox()
        {
            var textBox = new TextBox();
            textBox.Location = new Point(dataSetSources.Last().cellReferenceForDataSet.Location.X, dataSetSources.Last().cellReferenceForDataSet.Location.Y + 25);
            textBox.Visible = true;
            textBox.Size = new Size(100, 20);
            Controls.Add(textBox);
            return textBox;
        }
        private void chooseSaveLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                MarksheetsSaveLocation = folderBrowserDialog.SelectedPath;
                savePathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void startMakerButton_Click(object sender, EventArgs e)
        {
            if(markingTemplate == null)
            {
                DialogResult result = MessageBox.Show("No template file selected.", "Missing template file", MessageBoxButtons.OK);
            }
            else if(markingData == null)
            {
                DialogResult result = MessageBox.Show("No marking data file selected.", "Missing marking data", MessageBoxButtons.OK);
            }
            else if(MarksheetsSaveLocation == null)
            {
                DialogResult result = MessageBox.Show("Please choose the folder the marksheets should be saved to.", "Save location not specified", MessageBoxButtons.OK);
            }
            else if(dataSetSources[0].selectedColumn.SelectedItem == null)
            {
                DialogResult result = MessageBox.Show("Please select at least one column from the marking data.", "No data columns selected", MessageBoxButtons.OK);
            }
            else
            { 
                xlApp.Visible = false;
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(markingTemplate.file);
                Excel.Worksheet worksheet = xlWorkBook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;
                progressBar1.Maximum = markingData.markingData.Rows.Count;
                progressBar1.Step = 1;
                progressBar1.Value = 1;
                foreach (DataRow row in markingData.markingData.Rows)
                {
                    var dfsg = row.ItemArray.All(field => string.IsNullOrEmpty(field.ToString()));
                    if (row.ItemArray.All(field => string.IsNullOrEmpty(field.ToString())))
                    {
                        continue;
                    }
                    else
                    {
                        string marksheetSavePath = MarksheetsSaveLocation + "\\";
                        foreach (DataSetSource dataSetSource in dataSetSources)
                        {
                            worksheet.Range[dataSetSource.cellReferenceForDataSet.Text].Value = row[dataSetSource.selectedColumn.SelectedItem.ToString()].ToString();
                            if (dataSetSource.columnNameInMarksheetName.Checked)
                            {
                                if (dataSetSource == dataSetSources.Last())
                                {
                                    marksheetSavePath = marksheetSavePath + row[dataSetSource.selectedColumn.SelectedItem.ToString()].ToString();
                                }
                                else
                                {
                                    marksheetSavePath = marksheetSavePath + row[dataSetSource.selectedColumn.SelectedItem.ToString()].ToString() + "_";
                                }
                            }
                        }
                        xlWorkBook.SaveAs(marksheetSavePath);
                        progressBar1.PerformStep();
                    }
                }
                xlWorkBook.Close();
                xlApp.Quit();
            }
        }

        private void closeToolButton_Click(object sender, EventArgs e)
        {

        }
    }
}
