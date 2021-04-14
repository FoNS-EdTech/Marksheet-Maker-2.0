using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marksheet_Maker_2._0
{
    public partial class Form1 : Form
    {
        List<DataSetSource> dataSetSources = new List<DataSetSource>();
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
                /*
                MarkingDataSheet markingDataSheet = new MarkingDataSheet();
                markingDataSheet.file = fileDialog.FileName;
                markingDataSheet.fileStream = fileDialog.OpenFile();
                */

                MarkingData markingData = new MarkingData();
                markingData.CSVToMarkingData(fileDialog.FileName);
                foreach(DataSetSource dataSetSource in dataSetSources)
                {
                    dataSetSource.selectedColumn.Items.AddRange(markingData.markingDataColumnHeadings.ToArray());
                }
                //dataColumnSelectionComboBox.Items.AddRange(markingData.markingDataColumnHeadings.ToArray());
            }

        }

        private void chooseTemplateFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MarksheetTemplate markingTemplate = new MarksheetTemplate();
                markingTemplate.file = fileDialog.FileName;
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
        private CheckBox newCheckBox()
        {
            var checkBox = new CheckBox();
            checkBox.Location = new Point(dataSetSources.Last().columnNameInMarksheetName.Location.X, dataSetSources.Last().columnNameInMarksheetName.Location.Y + 25);
            checkBox.Visible = true;
            checkBox.Size = new Size(15, 14);
            Controls.Add(checkBox);
            return checkBox;
        }
        private TextBox newTextBox()
        {
            var textBox = new TextBox();
            textBox.Location = new Point(dataSetSources.Last().cellReferenceForDataSet.Location.X, dataSetSources.Last().cellReferenceForDataSet.Location.Y + 25);
            textBox.Visible = true;
            textBox.Size = new Size(100, 20);
            Controls.Add(textBox);
            return textBox;
        }
        private void indicateNameField_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseSaveLocationButton_Click(object sender, EventArgs e)
        {

        }

        private void startMakerButton_Click(object sender, EventArgs e)
        {

        }

        private void closeToolButton_Click(object sender, EventArgs e)
        {

        }
    }
}
