namespace JSONDatabaseBuilder
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Motors = new System.Windows.Forms.TabPage();
            this.dataMotors = new System.Windows.Forms.DataGridView();
            this.Arms = new System.Windows.Forms.TabPage();
            this.dataArms = new System.Windows.Forms.DataGridView();
            this.Blades = new System.Windows.Forms.TabPage();
            this.dataBlades = new System.Windows.Forms.DataGridView();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.TabPage();
            this.outputData = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.appendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bladeMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hohDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bladeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiperMotorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.wiperArmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiperBladeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wiperMotorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wiperMotorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bladeLengthMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bladeLengthMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Motors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMotors)).BeginInit();
            this.Arms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataArms)).BeginInit();
            this.Blades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBlades)).BeginInit();
            this.Data.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiperMotorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperArmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperBladeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperMotorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperMotorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Motors);
            this.tabControl1.Controls.Add(this.Arms);
            this.tabControl1.Controls.Add(this.Blades);
            this.tabControl1.Controls.Add(this.Data);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 538);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.Data_Click);
            // 
            // Motors
            // 
            this.Motors.Controls.Add(this.dataMotors);
            this.Motors.Location = new System.Drawing.Point(4, 22);
            this.Motors.Name = "Motors";
            this.Motors.Padding = new System.Windows.Forms.Padding(3);
            this.Motors.Size = new System.Drawing.Size(1030, 512);
            this.Motors.TabIndex = 0;
            this.Motors.Text = "Motors";
            this.Motors.UseVisualStyleBackColor = true;
            // 
            // dataMotors
            // 
            this.dataMotors.AllowDrop = true;
            this.dataMotors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMotors.AutoGenerateColumns = false;
            this.dataMotors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMotors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.armMaxDataGridViewTextBoxColumn,
            this.bladeMaxDataGridViewTextBoxColumn,
            this.hohDataGridViewTextBoxColumn,
            this.armTypeDataGridViewTextBoxColumn,
            this.bladeTypeDataGridViewTextBoxColumn,
            this.artNrDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataMotors.DataSource = this.wiperMotorBindingSource2;
            this.dataMotors.Location = new System.Drawing.Point(3, 3);
            this.dataMotors.Name = "dataMotors";
            this.dataMotors.Size = new System.Drawing.Size(1024, 506);
            this.dataMotors.TabIndex = 0;
            // 
            // Arms
            // 
            this.Arms.Controls.Add(this.dataArms);
            this.Arms.Location = new System.Drawing.Point(4, 22);
            this.Arms.Name = "Arms";
            this.Arms.Padding = new System.Windows.Forms.Padding(3);
            this.Arms.Size = new System.Drawing.Size(1030, 512);
            this.Arms.TabIndex = 1;
            this.Arms.Text = "Arms";
            this.Arms.UseVisualStyleBackColor = true;
            // 
            // dataArms
            // 
            this.dataArms.AllowDrop = true;
            this.dataArms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataArms.AutoGenerateColumns = false;
            this.dataArms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.applType,
            this.lengthMin,
            this.lengthMax,
            this.bladeLengthMin,
            this.bladeLengthMax,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataArms.DataSource = this.wiperArmBindingSource;
            this.dataArms.Location = new System.Drawing.Point(3, 3);
            this.dataArms.Name = "dataArms";
            this.dataArms.Size = new System.Drawing.Size(1024, 506);
            this.dataArms.TabIndex = 1;
            // 
            // Blades
            // 
            this.Blades.Controls.Add(this.dataBlades);
            this.Blades.Location = new System.Drawing.Point(4, 22);
            this.Blades.Name = "Blades";
            this.Blades.Padding = new System.Windows.Forms.Padding(3);
            this.Blades.Size = new System.Drawing.Size(1030, 512);
            this.Blades.TabIndex = 2;
            this.Blades.Text = "Blades";
            this.Blades.UseVisualStyleBackColor = true;
            // 
            // dataBlades
            // 
            this.dataBlades.AllowDrop = true;
            this.dataBlades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBlades.AutoGenerateColumns = false;
            this.dataBlades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBlades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.length,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataBlades.DataSource = this.wiperBladeBindingSource;
            this.dataBlades.Location = new System.Drawing.Point(3, 3);
            this.dataBlades.Name = "dataBlades";
            this.dataBlades.Size = new System.Drawing.Size(1024, 506);
            this.dataBlades.TabIndex = 1;
            // 
            // length
            // 
            this.length.DataPropertyName = "length";
            this.length.HeaderText = "length";
            this.length.Name = "length";
            // 
            // Data
            // 
            this.Data.Controls.Add(this.outputData);
            this.Data.Location = new System.Drawing.Point(4, 22);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(3);
            this.Data.Size = new System.Drawing.Size(1030, 512);
            this.Data.TabIndex = 3;
            this.Data.Text = "Data";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // outputData
            // 
            this.outputData.AcceptsReturn = true;
            this.outputData.AcceptsTab = true;
            this.outputData.AllowDrop = true;
            this.outputData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputData.CausesValidation = false;
            this.outputData.Location = new System.Drawing.Point(6, 6);
            this.outputData.Multiline = true;
            this.outputData.Name = "outputData";
            this.outputData.ReadOnly = true;
            this.outputData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputData.Size = new System.Drawing.Size(1018, 500);
            this.outputData.TabIndex = 0;
            this.outputData.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.appendToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // appendToolStripMenuItem
            // 
            this.appendToolStripMenuItem.Name = "appendToolStripMenuItem";
            this.appendToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.appendToolStripMenuItem.Text = "Append";
            this.appendToolStripMenuItem.Click += new System.EventHandler(this.appendToolStripMenuItem_Click);
            // 
            // armMaxDataGridViewTextBoxColumn
            // 
            this.armMaxDataGridViewTextBoxColumn.DataPropertyName = "armMax";
            this.armMaxDataGridViewTextBoxColumn.HeaderText = "armMax";
            this.armMaxDataGridViewTextBoxColumn.Name = "armMaxDataGridViewTextBoxColumn";
            // 
            // bladeMaxDataGridViewTextBoxColumn
            // 
            this.bladeMaxDataGridViewTextBoxColumn.DataPropertyName = "bladeMax";
            this.bladeMaxDataGridViewTextBoxColumn.HeaderText = "bladeMax";
            this.bladeMaxDataGridViewTextBoxColumn.Name = "bladeMaxDataGridViewTextBoxColumn";
            // 
            // hohDataGridViewTextBoxColumn
            // 
            this.hohDataGridViewTextBoxColumn.DataPropertyName = "hoh";
            this.hohDataGridViewTextBoxColumn.HeaderText = "hoh";
            this.hohDataGridViewTextBoxColumn.Name = "hohDataGridViewTextBoxColumn";
            // 
            // armTypeDataGridViewTextBoxColumn
            // 
            this.armTypeDataGridViewTextBoxColumn.DataPropertyName = "armType";
            this.armTypeDataGridViewTextBoxColumn.HeaderText = "armType";
            this.armTypeDataGridViewTextBoxColumn.Name = "armTypeDataGridViewTextBoxColumn";
            // 
            // bladeTypeDataGridViewTextBoxColumn
            // 
            this.bladeTypeDataGridViewTextBoxColumn.DataPropertyName = "bladeType";
            this.bladeTypeDataGridViewTextBoxColumn.HeaderText = "bladeType";
            this.bladeTypeDataGridViewTextBoxColumn.Name = "bladeTypeDataGridViewTextBoxColumn";
            // 
            // artNrDataGridViewTextBoxColumn
            // 
            this.artNrDataGridViewTextBoxColumn.DataPropertyName = "artNr";
            this.artNrDataGridViewTextBoxColumn.HeaderText = "artNr";
            this.artNrDataGridViewTextBoxColumn.Name = "artNrDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // wiperMotorBindingSource2
            // 
            this.wiperMotorBindingSource2.DataSource = typeof(JSONDatabaseBuilder.WiperMotor);
            // 
            // wiperArmBindingSource
            // 
            this.wiperArmBindingSource.DataSource = typeof(JSONDatabaseBuilder.WiperArm);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "bladeType";
            this.dataGridViewTextBoxColumn13.HeaderText = "bladeType";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "artNr";
            this.dataGridViewTextBoxColumn14.HeaderText = "artNr";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn15.HeaderText = "name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn16.HeaderText = "comment";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // wiperBladeBindingSource
            // 
            this.wiperBladeBindingSource.DataSource = typeof(JSONDatabaseBuilder.WiperBlade);
            // 
            // wiperMotorBindingSource1
            // 
            this.wiperMotorBindingSource1.DataSource = typeof(JSONDatabaseBuilder.WiperMotor);
            // 
            // wiperMotorBindingSource
            // 
            this.wiperMotorBindingSource.DataSource = typeof(JSONDatabaseBuilder.WiperMotor);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hoh";
            this.dataGridViewTextBoxColumn3.HeaderText = "hoh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // applType
            // 
            this.applType.DataPropertyName = "applType";
            this.applType.HeaderText = "applType";
            this.applType.Name = "applType";
            // 
            // lengthMin
            // 
            this.lengthMin.DataPropertyName = "lengthMin";
            this.lengthMin.HeaderText = "lengthMin";
            this.lengthMin.Name = "lengthMin";
            // 
            // lengthMax
            // 
            this.lengthMax.DataPropertyName = "lengthMax";
            this.lengthMax.HeaderText = "lengthMax";
            this.lengthMax.Name = "lengthMax";
            // 
            // bladeLengthMin
            // 
            this.bladeLengthMin.DataPropertyName = "bladeLengthMin";
            this.bladeLengthMin.HeaderText = "bladeLengthMin";
            this.bladeLengthMin.Name = "bladeLengthMin";
            // 
            // bladeLengthMax
            // 
            this.bladeLengthMax.DataPropertyName = "bladeLengthMax";
            this.bladeLengthMax.HeaderText = "bladeLengthMax";
            this.bladeLengthMax.Name = "bladeLengthMax";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "armType";
            this.dataGridViewTextBoxColumn4.HeaderText = "armType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bladeType";
            this.dataGridViewTextBoxColumn5.HeaderText = "bladeType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "artNr";
            this.dataGridViewTextBoxColumn6.HeaderText = "artNr";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn7.HeaderText = "name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "comment";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 577);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "JSON Database Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Motors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMotors)).EndInit();
            this.Arms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataArms)).EndInit();
            this.Blades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBlades)).EndInit();
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiperMotorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperArmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperBladeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperMotorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiperMotorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Motors;
        private System.Windows.Forms.TabPage Arms;
        private System.Windows.Forms.DataGridView dataMotors;
        private System.Windows.Forms.BindingSource wiperMotorBindingSource;
        private System.Windows.Forms.BindingSource wiperMotorBindingSource1;
        private System.Windows.Forms.BindingSource wiperMotorBindingSource2;
        private System.Windows.Forms.DataGridView dataArms;
        private System.Windows.Forms.BindingSource wiperArmBindingSource;
        private System.Windows.Forms.TabPage Blades;
        private System.Windows.Forms.DataGridView dataBlades;
        private System.Windows.Forms.BindingSource wiperBladeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.TabPage Data;
        private System.Windows.Forms.TextBox outputData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn armMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bladeMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hohDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn armTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bladeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem appendToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn applType;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn bladeLengthMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn bladeLengthMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

