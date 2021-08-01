namespace MobilityAppVersionFinder
{
    partial class mainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.fileStaticLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.appCountLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.appTable = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.androidVersionOldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOSVersionOldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.androidVersionNewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOSVersionNewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(193, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "App Meta Data Finder";
            // 
            // fileStaticLabel
            // 
            this.fileStaticLabel.AutoSize = true;
            this.fileStaticLabel.Location = new System.Drawing.Point(14, 54);
            this.fileStaticLabel.Name = "fileStaticLabel";
            this.fileStaticLabel.Size = new System.Drawing.Size(97, 13);
            this.fileStaticLabel.TabIndex = 1;
            this.fileStaticLabel.Text = "Selected Excel file:";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(118, 54);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(155, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "No file selected. Click to select.";
            this.fileNameLabel.Click += new System.EventHandler(this.fileNameLabel_Click);
            // 
            // appCountLabel
            // 
            this.appCountLabel.AutoSize = true;
            this.appCountLabel.Location = new System.Drawing.Point(14, 90);
            this.appCountLabel.Name = "appCountLabel";
            this.appCountLabel.Size = new System.Drawing.Size(80, 13);
            this.appCountLabel.TabIndex = 4;
            this.appCountLabel.Text = "No apps found.";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(121, 85);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(135, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check for new versions";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(271, 85);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update Excel file";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // appTable
            // 
            this.appTable.AllowUserToAddRows = false;
            this.appTable.AllowUserToDeleteRows = false;
            this.appTable.AutoGenerateColumns = false;
            this.appTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.androidVersionOldDataGridViewTextBoxColumn,
            this.iOSVersionOldDataGridViewTextBoxColumn,
            this.androidVersionNewDataGridViewTextBoxColumn,
            this.iOSVersionNewDataGridViewTextBoxColumn});
            this.appTable.DataSource = this.appBindingSource;
            this.appTable.Location = new System.Drawing.Point(12, 132);
            this.appTable.Name = "appTable";
            this.appTable.ReadOnly = true;
            this.appTable.Size = new System.Drawing.Size(771, 271);
            this.appTable.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "App Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // androidVersionOldDataGridViewTextBoxColumn
            // 
            this.androidVersionOldDataGridViewTextBoxColumn.DataPropertyName = "AndroidVersionOld";
            this.androidVersionOldDataGridViewTextBoxColumn.HeaderText = "Last seen Android Version";
            this.androidVersionOldDataGridViewTextBoxColumn.Name = "androidVersionOldDataGridViewTextBoxColumn";
            this.androidVersionOldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iOSVersionOldDataGridViewTextBoxColumn
            // 
            this.iOSVersionOldDataGridViewTextBoxColumn.DataPropertyName = "IOSVersionOld";
            this.iOSVersionOldDataGridViewTextBoxColumn.HeaderText = "Last seen iOS Version";
            this.iOSVersionOldDataGridViewTextBoxColumn.Name = "iOSVersionOldDataGridViewTextBoxColumn";
            this.iOSVersionOldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // androidVersionNewDataGridViewTextBoxColumn
            // 
            this.androidVersionNewDataGridViewTextBoxColumn.DataPropertyName = "AndroidVersionNew";
            this.androidVersionNewDataGridViewTextBoxColumn.HeaderText = "New Android Version";
            this.androidVersionNewDataGridViewTextBoxColumn.Name = "androidVersionNewDataGridViewTextBoxColumn";
            this.androidVersionNewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iOSVersionNewDataGridViewTextBoxColumn
            // 
            this.iOSVersionNewDataGridViewTextBoxColumn.DataPropertyName = "IOSVersionNew";
            this.iOSVersionNewDataGridViewTextBoxColumn.HeaderText = "New iOS Version";
            this.iOSVersionNewDataGridViewTextBoxColumn.Name = "iOSVersionNewDataGridViewTextBoxColumn";
            this.iOSVersionNewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appBindingSource
            // 
            this.appBindingSource.DataSource = typeof(MobilityAppVersionFinder.data.App);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 428);
            this.Controls.Add(this.appTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.appCountLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileStaticLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "App Meta Data Finder";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fileStaticLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label appCountLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView appTable;
        private System.Windows.Forms.BindingSource appBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn androidVersionOldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOSVersionOldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn androidVersionNewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOSVersionNewDataGridViewTextBoxColumn;
    }
}

