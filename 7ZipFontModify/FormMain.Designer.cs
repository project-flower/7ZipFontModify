namespace SevenZipFontModify
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFiles = new System.Windows.Forms.Label();
            this.textBoxFiles = new System.Windows.Forms.TextBox();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.numericUpDownFontSizeFrom = new System.Windows.Forms.NumericUpDown();
            this.labelFontSizeTo = new System.Windows.Forms.Label();
            this.numericUpDownFontSizeTo = new System.Windows.Forms.NumericUpDown();
            this.labelBackupTo = new System.Windows.Forms.Label();
            this.textBoxBackupTo = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSizeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSizeTo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(12, 9);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(32, 12);
            this.labelFiles.TabIndex = 0;
            this.labelFiles.Text = "&Files:";
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFiles.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SevenZipFontModify.Properties.Settings.Default, "Files", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFiles.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFiles.Location = new System.Drawing.Point(12, 24);
            this.textBoxFiles.Multiline = true;
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFiles.Size = new System.Drawing.Size(776, 42);
            this.textBoxFiles.TabIndex = 1;
            this.textBoxFiles.Text = global::SevenZipFontModify.Properties.Settings.Default.Files;
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(12, 69);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(54, 12);
            this.labelFontSize.TabIndex = 2;
            this.labelFontSize.Text = "Font &size:";
            // 
            // numericUpDownFontSizeFrom
            // 
            this.numericUpDownFontSizeFrom.Location = new System.Drawing.Point(12, 84);
            this.numericUpDownFontSizeFrom.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownFontSizeFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFontSizeFrom.Name = "numericUpDownFontSizeFrom";
            this.numericUpDownFontSizeFrom.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownFontSizeFrom.TabIndex = 3;
            this.numericUpDownFontSizeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFontSizeFrom.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // labelFontSizeTo
            // 
            this.labelFontSizeTo.AutoSize = true;
            this.labelFontSizeTo.Location = new System.Drawing.Point(78, 86);
            this.labelFontSizeTo.Name = "labelFontSizeTo";
            this.labelFontSizeTo.Size = new System.Drawing.Size(15, 12);
            this.labelFontSizeTo.TabIndex = 4;
            this.labelFontSizeTo.Text = "&to";
            // 
            // numericUpDownFontSizeTo
            // 
            this.numericUpDownFontSizeTo.Location = new System.Drawing.Point(99, 84);
            this.numericUpDownFontSizeTo.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownFontSizeTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFontSizeTo.Name = "numericUpDownFontSizeTo";
            this.numericUpDownFontSizeTo.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownFontSizeTo.TabIndex = 5;
            this.numericUpDownFontSizeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFontSizeTo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelBackupTo
            // 
            this.labelBackupTo.AutoSize = true;
            this.labelBackupTo.Location = new System.Drawing.Point(12, 106);
            this.labelBackupTo.Name = "labelBackupTo";
            this.labelBackupTo.Size = new System.Drawing.Size(59, 12);
            this.labelBackupTo.TabIndex = 6;
            this.labelBackupTo.Text = "&Backup to:";
            // 
            // textBoxBackupTo
            // 
            this.textBoxBackupTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBackupTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxBackupTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBoxBackupTo.Location = new System.Drawing.Point(12, 121);
            this.textBoxBackupTo.Name = "textBoxBackupTo";
            this.textBoxBackupTo.Size = new System.Drawing.Size(776, 19);
            this.textBoxBackupTo.TabIndex = 7;
            // 
            // buttonExec
            // 
            this.buttonExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExec.Location = new System.Drawing.Point(713, 146);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 8;
            this.buttonExec.Text = "&Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 181);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.textBoxBackupTo);
            this.Controls.Add(this.labelBackupTo);
            this.Controls.Add(this.numericUpDownFontSizeTo);
            this.Controls.Add(this.labelFontSizeTo);
            this.Controls.Add(this.numericUpDownFontSizeFrom);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.textBoxFiles);
            this.Controls.Add(this.labelFiles);
            this.Name = "FormMain";
            this.Text = "7-Zip Font Modify";
            this.Shown += new System.EventHandler(this.shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSizeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSizeTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.TextBox textBoxFiles;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSizeFrom;
        private System.Windows.Forms.Label labelFontSizeTo;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSizeTo;
        private System.Windows.Forms.Label labelBackupTo;
        private System.Windows.Forms.TextBox textBoxBackupTo;
        private System.Windows.Forms.Button buttonExec;
    }
}

