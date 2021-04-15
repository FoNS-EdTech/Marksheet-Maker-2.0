
namespace Marksheet_Maker_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectMarkingInfoButton = new System.Windows.Forms.Button();
            this.chooseTemplateFileButton = new System.Windows.Forms.Button();
            this.chooseMarkingInfoLabel = new System.Windows.Forms.Label();
            this.chooseTemplateLabel = new System.Windows.Forms.Label();
            this.templateCellLocation = new System.Windows.Forms.TextBox();
            this.chooseSaveLocationButton = new System.Windows.Forms.Button();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.startMakerButton = new System.Windows.Forms.Button();
            this.closeToolButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.addFieldButton = new System.Windows.Forms.Button();
            this.dataColumnSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.indicateNameField = new System.Windows.Forms.CheckBox();
            this.markingDataLabel = new System.Windows.Forms.Label();
            this.marksheetTemplateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectMarkingInfoButton
            // 
            this.selectMarkingInfoButton.Location = new System.Drawing.Point(24, 48);
            this.selectMarkingInfoButton.Name = "selectMarkingInfoButton";
            this.selectMarkingInfoButton.Size = new System.Drawing.Size(75, 23);
            this.selectMarkingInfoButton.TabIndex = 0;
            this.selectMarkingInfoButton.Text = "Choose";
            this.selectMarkingInfoButton.UseVisualStyleBackColor = true;
            this.selectMarkingInfoButton.Click += new System.EventHandler(this.selectMarkingInfoButton_Click);
            // 
            // chooseTemplateFileButton
            // 
            this.chooseTemplateFileButton.Location = new System.Drawing.Point(376, 48);
            this.chooseTemplateFileButton.Name = "chooseTemplateFileButton";
            this.chooseTemplateFileButton.Size = new System.Drawing.Size(75, 23);
            this.chooseTemplateFileButton.TabIndex = 1;
            this.chooseTemplateFileButton.Text = "Choose";
            this.chooseTemplateFileButton.UseVisualStyleBackColor = true;
            this.chooseTemplateFileButton.Click += new System.EventHandler(this.chooseTemplateFileButton_Click);
            // 
            // chooseMarkingInfoLabel
            // 
            this.chooseMarkingInfoLabel.AutoSize = true;
            this.chooseMarkingInfoLabel.Location = new System.Drawing.Point(24, 29);
            this.chooseMarkingInfoLabel.Name = "chooseMarkingInfoLabel";
            this.chooseMarkingInfoLabel.Size = new System.Drawing.Size(239, 13);
            this.chooseMarkingInfoLabel.TabIndex = 2;
            this.chooseMarkingInfoLabel.Text = "Choose the spreadsheet to pull marking info from:";
            // 
            // chooseTemplateLabel
            // 
            this.chooseTemplateLabel.AutoSize = true;
            this.chooseTemplateLabel.Location = new System.Drawing.Point(376, 29);
            this.chooseTemplateLabel.Name = "chooseTemplateLabel";
            this.chooseTemplateLabel.Size = new System.Drawing.Size(144, 13);
            this.chooseTemplateLabel.TabIndex = 3;
            this.chooseTemplateLabel.Text = "Choose mark sheet template:";
            // 
            // templateCellLocation
            // 
            this.templateCellLocation.Location = new System.Drawing.Point(376, 104);
            this.templateCellLocation.Name = "templateCellLocation";
            this.templateCellLocation.Size = new System.Drawing.Size(100, 20);
            this.templateCellLocation.TabIndex = 0;
            // 
            // chooseSaveLocationButton
            // 
            this.chooseSaveLocationButton.Location = new System.Drawing.Point(24, 398);
            this.chooseSaveLocationButton.Name = "chooseSaveLocationButton";
            this.chooseSaveLocationButton.Size = new System.Drawing.Size(75, 23);
            this.chooseSaveLocationButton.TabIndex = 6;
            this.chooseSaveLocationButton.Text = "Choose";
            this.chooseSaveLocationButton.UseVisualStyleBackColor = true;
            this.chooseSaveLocationButton.Click += new System.EventHandler(this.chooseSaveLocationButton_Click);
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(105, 400);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.ReadOnly = true;
            this.savePathTextBox.Size = new System.Drawing.Size(243, 20);
            this.savePathTextBox.TabIndex = 7;
            // 
            // startMakerButton
            // 
            this.startMakerButton.Location = new System.Drawing.Point(481, 398);
            this.startMakerButton.Name = "startMakerButton";
            this.startMakerButton.Size = new System.Drawing.Size(75, 23);
            this.startMakerButton.TabIndex = 8;
            this.startMakerButton.Text = "Start";
            this.startMakerButton.UseVisualStyleBackColor = true;
            this.startMakerButton.Click += new System.EventHandler(this.startMakerButton_Click);
            // 
            // closeToolButton
            // 
            this.closeToolButton.Location = new System.Drawing.Point(562, 398);
            this.closeToolButton.Name = "closeToolButton";
            this.closeToolButton.Size = new System.Drawing.Size(75, 23);
            this.closeToolButton.TabIndex = 9;
            this.closeToolButton.Text = "Cancel";
            this.closeToolButton.UseVisualStyleBackColor = true;
            this.closeToolButton.Click += new System.EventHandler(this.closeToolButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(481, 369);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // addFieldButton
            // 
            this.addFieldButton.Location = new System.Drawing.Point(26, 104);
            this.addFieldButton.Name = "addFieldButton";
            this.addFieldButton.Size = new System.Drawing.Size(23, 23);
            this.addFieldButton.TabIndex = 0;
            this.addFieldButton.Text = "+";
            this.addFieldButton.UseVisualStyleBackColor = true;
            this.addFieldButton.Click += new System.EventHandler(this.addFieldButton_Click);
            // 
            // dataColumnSelectionComboBox
            // 
            this.dataColumnSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataColumnSelectionComboBox.FormattingEnabled = true;
            this.dataColumnSelectionComboBox.Location = new System.Drawing.Point(55, 105);
            this.dataColumnSelectionComboBox.Name = "dataColumnSelectionComboBox";
            this.dataColumnSelectionComboBox.Size = new System.Drawing.Size(262, 21);
            this.dataColumnSelectionComboBox.TabIndex = 1;
            // 
            // indicateNameField
            // 
            this.indicateNameField.AutoSize = true;
            this.indicateNameField.Checked = true;
            this.indicateNameField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.indicateNameField.Enabled = false;
            this.indicateNameField.Location = new System.Drawing.Point(323, 108);
            this.indicateNameField.Name = "indicateNameField";
            this.indicateNameField.Size = new System.Drawing.Size(15, 14);
            this.indicateNameField.TabIndex = 2;
            this.indicateNameField.UseVisualStyleBackColor = true;
            // 
            // markingDataLabel
            // 
            this.markingDataLabel.AutoSize = true;
            this.markingDataLabel.Location = new System.Drawing.Point(106, 53);
            this.markingDataLabel.Name = "markingDataLabel";
            this.markingDataLabel.Size = new System.Drawing.Size(0, 13);
            this.markingDataLabel.TabIndex = 11;
            // 
            // marksheetTemplateLabel
            // 
            this.marksheetTemplateLabel.AutoSize = true;
            this.marksheetTemplateLabel.Location = new System.Drawing.Point(457, 53);
            this.marksheetTemplateLabel.Name = "marksheetTemplateLabel";
            this.marksheetTemplateLabel.Size = new System.Drawing.Size(0, 13);
            this.marksheetTemplateLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.marksheetTemplateLabel);
            this.Controls.Add(this.markingDataLabel);
            this.Controls.Add(this.templateCellLocation);
            this.Controls.Add(this.addFieldButton);
            this.Controls.Add(this.indicateNameField);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataColumnSelectionComboBox);
            this.Controls.Add(this.closeToolButton);
            this.Controls.Add(this.startMakerButton);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.chooseSaveLocationButton);
            this.Controls.Add(this.chooseTemplateLabel);
            this.Controls.Add(this.chooseMarkingInfoLabel);
            this.Controls.Add(this.chooseTemplateFileButton);
            this.Controls.Add(this.selectMarkingInfoButton);
            this.Name = "Form1";
            this.Text = "Mark Sheet Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectMarkingInfoButton;
        private System.Windows.Forms.Button chooseTemplateFileButton;
        private System.Windows.Forms.Label chooseMarkingInfoLabel;
        private System.Windows.Forms.Label chooseTemplateLabel;
        private System.Windows.Forms.TextBox templateCellLocation;
        private System.Windows.Forms.Button chooseSaveLocationButton;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.Button startMakerButton;
        private System.Windows.Forms.Button closeToolButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button addFieldButton;
        private System.Windows.Forms.ComboBox dataColumnSelectionComboBox;
        private System.Windows.Forms.CheckBox indicateNameField;
        private System.Windows.Forms.Label markingDataLabel;
        private System.Windows.Forms.Label marksheetTemplateLabel;
    }
}

