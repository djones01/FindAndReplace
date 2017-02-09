namespace FindAndReplace
{
    partial class ReplaceForm
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
            this.openFileDialogSource = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogKV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogResult = new System.Windows.Forms.SaveFileDialog();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.tabPageRun = new System.Windows.Forms.TabPage();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonRunReplace = new System.Windows.Forms.Button();
            this.tabPageKeyValues = new System.Windows.Forms.TabPage();
            this.groupBoxKVTwo = new System.Windows.Forms.GroupBox();
            this.buttonClearKVTwo = new System.Windows.Forms.Button();
            this.dataGridViewKVTwo = new System.Windows.Forms.DataGridView();
            this.buttonSelectKVTwo = new System.Windows.Forms.Button();
            this.groupBoxKVOne = new System.Windows.Forms.GroupBox();
            this.buttonClearKVOne = new System.Windows.Forms.Button();
            this.dataGridViewKVOne = new System.Windows.Forms.DataGridView();
            this.buttonSelectKVOne = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.tabPageSource = new System.Windows.Forms.TabPage();
            this.webBrowserXML = new System.Windows.Forms.WebBrowser();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttonClearSource = new System.Windows.Forms.Button();
            this.buttonSelectSource = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLogs.SuspendLayout();
            this.tabPageRun.SuspendLayout();
            this.tabPageKeyValues.SuspendLayout();
            this.groupBoxKVTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKVTwo)).BeginInit();
            this.groupBoxKVOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKVOne)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageSource.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogSource
            // 
            this.openFileDialogSource.Filter = "All Files (*.*)|*.*|Text files (*.txt)|*.txt|Comma Delimited Files (*.csv*)|*.csv" +
    "*|Data Files (*.dat*)|*.dat*|XML Files (*.xml*)|*.xml*|JSON Files (*.json*)|*.js" +
    "on*\"";
            // 
            // openFileDialogKV
            // 
            this.openFileDialogKV.Filter = "All Files (*.*)|*.*|Text files (*.txt)|*.txt|Comma Delimited Files (*.csv*)|*.csv" +
    "*|Data Files (*.dat*)|*.dat*|XML Files (*.xml*)|*.xml*|JSON Files (*.json*)|*.js" +
    "on*\"";
            // 
            // saveFileDialogResult
            // 
            this.saveFileDialogResult.Filter = "All Files (*.*)|*.*|Text files (*.txt)|*.txt|Comma Delimited Files (*.csv*)|*.csv" +
    "*|Data Files (*.dat*)|*.dat*|XML Files (*.xml*)|*.xml*|JSON Files (*.json*)|*.js" +
    "on*\"";
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.textBoxLogs);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(875, 689);
            this.tabPageLogs.TabIndex = 3;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.Location = new System.Drawing.Point(6, 6);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLogs.Size = new System.Drawing.Size(863, 677);
            this.textBoxLogs.TabIndex = 0;
            // 
            // tabPageRun
            // 
            this.tabPageRun.Controls.Add(this.buttonSaveResult);
            this.tabPageRun.Controls.Add(this.buttonClearAll);
            this.tabPageRun.Controls.Add(this.textBoxResult);
            this.tabPageRun.Controls.Add(this.buttonRunReplace);
            this.tabPageRun.Location = new System.Drawing.Point(4, 22);
            this.tabPageRun.Name = "tabPageRun";
            this.tabPageRun.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRun.Size = new System.Drawing.Size(875, 689);
            this.tabPageRun.TabIndex = 2;
            this.tabPageRun.Text = "Run Replace";
            this.tabPageRun.UseVisualStyleBackColor = true;
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Enabled = false;
            this.buttonSaveResult.Location = new System.Drawing.Point(155, 6);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(143, 35);
            this.buttonSaveResult.TabIndex = 7;
            this.buttonSaveResult.Text = "Save Result";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(726, 6);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(143, 35);
            this.buttonClearAll.TabIndex = 6;
            this.buttonClearAll.Text = "Clear All Tabs";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 47);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(863, 636);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonRunReplace
            // 
            this.buttonRunReplace.Location = new System.Drawing.Point(6, 6);
            this.buttonRunReplace.Name = "buttonRunReplace";
            this.buttonRunReplace.Size = new System.Drawing.Size(143, 35);
            this.buttonRunReplace.TabIndex = 0;
            this.buttonRunReplace.Text = "Run Replace";
            this.buttonRunReplace.UseVisualStyleBackColor = true;
            this.buttonRunReplace.Click += new System.EventHandler(this.buttonRunReplace_Click);
            // 
            // tabPageKeyValues
            // 
            this.tabPageKeyValues.Controls.Add(this.groupBoxKVTwo);
            this.tabPageKeyValues.Controls.Add(this.groupBoxKVOne);
            this.tabPageKeyValues.Controls.Add(this.groupBox1);
            this.tabPageKeyValues.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeyValues.Name = "tabPageKeyValues";
            this.tabPageKeyValues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyValues.Size = new System.Drawing.Size(875, 689);
            this.tabPageKeyValues.TabIndex = 1;
            this.tabPageKeyValues.Text = "Replace Values";
            this.tabPageKeyValues.UseVisualStyleBackColor = true;
            // 
            // groupBoxKVTwo
            // 
            this.groupBoxKVTwo.Controls.Add(this.buttonClearKVTwo);
            this.groupBoxKVTwo.Controls.Add(this.dataGridViewKVTwo);
            this.groupBoxKVTwo.Controls.Add(this.buttonSelectKVTwo);
            this.groupBoxKVTwo.Location = new System.Drawing.Point(443, 96);
            this.groupBoxKVTwo.Name = "groupBoxKVTwo";
            this.groupBoxKVTwo.Size = new System.Drawing.Size(426, 587);
            this.groupBoxKVTwo.TabIndex = 3;
            this.groupBoxKVTwo.TabStop = false;
            this.groupBoxKVTwo.Text = "Input File 2";
            this.groupBoxKVTwo.Visible = false;
            // 
            // buttonClearKVTwo
            // 
            this.buttonClearKVTwo.Location = new System.Drawing.Point(277, 19);
            this.buttonClearKVTwo.Name = "buttonClearKVTwo";
            this.buttonClearKVTwo.Size = new System.Drawing.Size(143, 35);
            this.buttonClearKVTwo.TabIndex = 5;
            this.buttonClearKVTwo.Text = "Clear";
            this.buttonClearKVTwo.UseVisualStyleBackColor = true;
            this.buttonClearKVTwo.Click += new System.EventHandler(this.buttonClearKVTwo_Click);
            // 
            // dataGridViewKVTwo
            // 
            this.dataGridViewKVTwo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKVTwo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewKVTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKVTwo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewKVTwo.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewKVTwo.Name = "dataGridViewKVTwo";
            this.dataGridViewKVTwo.Size = new System.Drawing.Size(414, 521);
            this.dataGridViewKVTwo.TabIndex = 4;
            // 
            // buttonSelectKVTwo
            // 
            this.buttonSelectKVTwo.Location = new System.Drawing.Point(6, 19);
            this.buttonSelectKVTwo.Name = "buttonSelectKVTwo";
            this.buttonSelectKVTwo.Size = new System.Drawing.Size(143, 35);
            this.buttonSelectKVTwo.TabIndex = 3;
            this.buttonSelectKVTwo.Text = "Select Key / Value File";
            this.buttonSelectKVTwo.UseVisualStyleBackColor = true;
            this.buttonSelectKVTwo.Click += new System.EventHandler(this.buttonSelectKVTwo_Click);
            // 
            // groupBoxKVOne
            // 
            this.groupBoxKVOne.Controls.Add(this.buttonClearKVOne);
            this.groupBoxKVOne.Controls.Add(this.dataGridViewKVOne);
            this.groupBoxKVOne.Controls.Add(this.buttonSelectKVOne);
            this.groupBoxKVOne.Location = new System.Drawing.Point(6, 96);
            this.groupBoxKVOne.Name = "groupBoxKVOne";
            this.groupBoxKVOne.Size = new System.Drawing.Size(426, 587);
            this.groupBoxKVOne.TabIndex = 2;
            this.groupBoxKVOne.TabStop = false;
            this.groupBoxKVOne.Text = "Input File 1";
            // 
            // buttonClearKVOne
            // 
            this.buttonClearKVOne.Location = new System.Drawing.Point(277, 19);
            this.buttonClearKVOne.Name = "buttonClearKVOne";
            this.buttonClearKVOne.Size = new System.Drawing.Size(143, 35);
            this.buttonClearKVOne.TabIndex = 2;
            this.buttonClearKVOne.Text = "Clear";
            this.buttonClearKVOne.UseVisualStyleBackColor = true;
            this.buttonClearKVOne.Click += new System.EventHandler(this.buttonClearKVOne_Click);
            // 
            // dataGridViewKVOne
            // 
            this.dataGridViewKVOne.AllowUserToAddRows = false;
            this.dataGridViewKVOne.AllowUserToDeleteRows = false;
            this.dataGridViewKVOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKVOne.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewKVOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKVOne.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewKVOne.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewKVOne.Name = "dataGridViewKVOne";
            this.dataGridViewKVOne.ReadOnly = true;
            this.dataGridViewKVOne.Size = new System.Drawing.Size(414, 521);
            this.dataGridViewKVOne.TabIndex = 1;
            // 
            // buttonSelectKVOne
            // 
            this.buttonSelectKVOne.Location = new System.Drawing.Point(6, 19);
            this.buttonSelectKVOne.Name = "buttonSelectKVOne";
            this.buttonSelectKVOne.Size = new System.Drawing.Size(143, 35);
            this.buttonSelectKVOne.TabIndex = 0;
            this.buttonSelectKVOne.Text = "Select Key / Value File";
            this.buttonSelectKVOne.UseVisualStyleBackColor = true;
            this.buttonSelectKVOne.Click += new System.EventHandler(this.buttonSelectKVOne_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDouble);
            this.groupBox1.Controls.Add(this.radioButtonSingle);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Key / Value Mode";
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Location = new System.Drawing.Point(22, 51);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(376, 17);
            this.radioButtonDouble.TabIndex = 1;
            this.radioButtonDouble.Text = "Double File - Keys and values are taken from two files and matched by key";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            this.radioButtonDouble.CheckedChanged += new System.EventHandler(this.radioButtonDouble_CheckedChanged);
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Checked = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(22, 28);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(484, 17);
            this.radioButtonSingle.TabIndex = 0;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single File - Keys and Values are taken from one file and lines are assumed to de" +
    "note a single pair";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.radioButtonSingle_CheckedChanged);
            // 
            // tabPageSource
            // 
            this.tabPageSource.Controls.Add(this.webBrowserXML);
            this.tabPageSource.Controls.Add(this.textBoxSource);
            this.tabPageSource.Controls.Add(this.buttonClearSource);
            this.tabPageSource.Controls.Add(this.buttonSelectSource);
            this.tabPageSource.Location = new System.Drawing.Point(4, 22);
            this.tabPageSource.Name = "tabPageSource";
            this.tabPageSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSource.Size = new System.Drawing.Size(875, 689);
            this.tabPageSource.TabIndex = 0;
            this.tabPageSource.Text = "Source";
            this.tabPageSource.UseVisualStyleBackColor = true;
            // 
            // webBrowserXML
            // 
            this.webBrowserXML.Location = new System.Drawing.Point(6, 59);
            this.webBrowserXML.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserXML.Name = "webBrowserXML";
            this.webBrowserXML.Size = new System.Drawing.Size(863, 624);
            this.webBrowserXML.TabIndex = 3;
            this.webBrowserXML.Visible = false;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(6, 59);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSource.Size = new System.Drawing.Size(863, 624);
            this.textBoxSource.TabIndex = 1;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // buttonClearSource
            // 
            this.buttonClearSource.Location = new System.Drawing.Point(726, 18);
            this.buttonClearSource.Name = "buttonClearSource";
            this.buttonClearSource.Size = new System.Drawing.Size(143, 35);
            this.buttonClearSource.TabIndex = 2;
            this.buttonClearSource.Text = "Clear";
            this.buttonClearSource.UseVisualStyleBackColor = true;
            this.buttonClearSource.Click += new System.EventHandler(this.buttonClearSource_Click);
            // 
            // buttonSelectSource
            // 
            this.buttonSelectSource.Location = new System.Drawing.Point(6, 18);
            this.buttonSelectSource.Name = "buttonSelectSource";
            this.buttonSelectSource.Size = new System.Drawing.Size(143, 35);
            this.buttonSelectSource.TabIndex = 0;
            this.buttonSelectSource.Text = "Select Source File";
            this.buttonSelectSource.UseVisualStyleBackColor = true;
            this.buttonSelectSource.Click += new System.EventHandler(this.buttonSelectSource_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSource);
            this.tabControlMain.Controls.Add(this.tabPageKeyValues);
            this.tabControlMain.Controls.Add(this.tabPageLogs);
            this.tabControlMain.Controls.Add(this.tabPageRun);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(883, 715);
            this.tabControlMain.TabIndex = 1;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 739);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ReplaceForm";
            this.Text = "Replace from Files";
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageLogs.PerformLayout();
            this.tabPageRun.ResumeLayout(false);
            this.tabPageRun.PerformLayout();
            this.tabPageKeyValues.ResumeLayout(false);
            this.groupBoxKVTwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKVTwo)).EndInit();
            this.groupBoxKVOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKVOne)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSource.ResumeLayout(false);
            this.tabPageSource.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogSource;
        private System.Windows.Forms.OpenFileDialog openFileDialogKV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogResult;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.TabPage tabPageRun;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonRunReplace;
        private System.Windows.Forms.TabPage tabPageKeyValues;
        private System.Windows.Forms.GroupBox groupBoxKVTwo;
        private System.Windows.Forms.Button buttonClearKVTwo;
        private System.Windows.Forms.DataGridView dataGridViewKVTwo;
        private System.Windows.Forms.Button buttonSelectKVTwo;
        private System.Windows.Forms.GroupBox groupBoxKVOne;
        private System.Windows.Forms.Button buttonClearKVOne;
        private System.Windows.Forms.DataGridView dataGridViewKVOne;
        private System.Windows.Forms.Button buttonSelectKVOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDouble;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.TabPage tabPageSource;
        private System.Windows.Forms.WebBrowser webBrowserXML;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button buttonClearSource;
        private System.Windows.Forms.Button buttonSelectSource;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TextBox textBoxLogs;
    }
}

