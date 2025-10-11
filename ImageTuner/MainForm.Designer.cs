namespace ImageTuner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblJPGQuality = new Label();
            lblSizePercentage = new Label();
            lblParallelCount = new Label();
            numJPGQuality = new NumericUpDown();
            numSizePercentage = new NumericUpDown();
            numParallelCount = new NumericUpDown();
            chkIgonreDateCheck = new CheckBox();
            chkRemoveOriginalFile = new CheckBox();
            chkExitApp = new CheckBox();
            btnResaveImage = new Button();
            btnResaveAllImage = new Button();
            btnResizeImage = new Button();
            btnResizeAllImage = new Button();
            lblFolder = new Label();
            lstLogging = new ListBox();
            btnClearLogging = new Button();
            ((System.ComponentModel.ISupportInitialize)numJPGQuality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSizePercentage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numParallelCount).BeginInit();
            SuspendLayout();
            // 
            // lblJPGQuality
            // 
            lblJPGQuality.AutoSize = true;
            lblJPGQuality.Location = new Point(62, 43);
            lblJPGQuality.Name = "lblJPGQuality";
            lblJPGQuality.Size = new Size(105, 25);
            lblJPGQuality.TabIndex = 0;
            lblJPGQuality.Text = "JPG Quality:";
            // 
            // lblSizePercentage
            // 
            lblSizePercentage.AutoSize = true;
            lblSizePercentage.Location = new Point(12, 94);
            lblSizePercentage.Name = "lblSizePercentage";
            lblSizePercentage.Size = new Size(155, 25);
            lblSizePercentage.TabIndex = 1;
            lblSizePercentage.Text = "Resize Percentage:";
            // 
            // lblParallelCount
            // 
            lblParallelCount.AutoSize = true;
            lblParallelCount.Location = new Point(44, 145);
            lblParallelCount.Name = "lblParallelCount";
            lblParallelCount.Size = new Size(123, 25);
            lblParallelCount.TabIndex = 2;
            lblParallelCount.Text = "Parallel Count:";
            // 
            // numJPGQuality
            // 
            numJPGQuality.Location = new Point(173, 41);
            numJPGQuality.Name = "numJPGQuality";
            numJPGQuality.Size = new Size(104, 31);
            numJPGQuality.TabIndex = 3;
            numJPGQuality.Value = new decimal(new int[] { 95, 0, 0, 0 });
            // 
            // numSizePercentage
            // 
            numSizePercentage.Location = new Point(173, 92);
            numSizePercentage.Name = "numSizePercentage";
            numSizePercentage.Size = new Size(104, 31);
            numSizePercentage.TabIndex = 4;
            numSizePercentage.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numParallelCount
            // 
            numParallelCount.Location = new Point(173, 143);
            numParallelCount.Name = "numParallelCount";
            numParallelCount.Size = new Size(104, 31);
            numParallelCount.TabIndex = 5;
            numParallelCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // chkIgonreDateCheck
            // 
            chkIgonreDateCheck.AutoSize = true;
            chkIgonreDateCheck.Location = new Point(44, 197);
            chkIgonreDateCheck.Name = "chkIgonreDateCheck";
            chkIgonreDateCheck.Size = new Size(184, 29);
            chkIgonreDateCheck.TabIndex = 6;
            chkIgonreDateCheck.Text = "Ignore Date Check";
            chkIgonreDateCheck.UseVisualStyleBackColor = true;
            // 
            // chkRemoveOriginalFile
            // 
            chkRemoveOriginalFile.AutoSize = true;
            chkRemoveOriginalFile.Checked = true;
            chkRemoveOriginalFile.CheckState = CheckState.Checked;
            chkRemoveOriginalFile.Location = new Point(44, 240);
            chkRemoveOriginalFile.Name = "chkRemoveOriginalFile";
            chkRemoveOriginalFile.Size = new Size(200, 29);
            chkRemoveOriginalFile.TabIndex = 7;
            chkRemoveOriginalFile.Text = "Remove Original File";
            chkRemoveOriginalFile.UseVisualStyleBackColor = true;
            // 
            // chkExitApp
            // 
            chkExitApp.AutoSize = true;
            chkExitApp.Checked = true;
            chkExitApp.CheckState = CheckState.Checked;
            chkExitApp.Location = new Point(44, 283);
            chkExitApp.Name = "chkExitApp";
            chkExitApp.Size = new Size(264, 29);
            chkExitApp.TabIndex = 8;
            chkExitApp.Text = "Exit application after process";
            chkExitApp.UseVisualStyleBackColor = true;
            // 
            // btnResaveImage
            // 
            btnResaveImage.Location = new Point(371, 44);
            btnResaveImage.Name = "btnResaveImage";
            btnResaveImage.Size = new Size(309, 95);
            btnResaveImage.TabIndex = 9;
            btnResaveImage.Text = "Resave Current Folder Image";
            btnResaveImage.UseVisualStyleBackColor = true;
            btnResaveImage.Click += btnResaveImage_Click;
            // 
            // btnResaveAllImage
            // 
            btnResaveAllImage.Location = new Point(717, 44);
            btnResaveAllImage.Name = "btnResaveAllImage";
            btnResaveAllImage.Size = new Size(309, 95);
            btnResaveAllImage.TabIndex = 10;
            btnResaveAllImage.Text = "Resave Current Folder All Image";
            btnResaveAllImage.UseVisualStyleBackColor = true;
            btnResaveAllImage.Click += btnResaveAllImage_Click;
            // 
            // btnResizeImage
            // 
            btnResizeImage.Location = new Point(371, 181);
            btnResizeImage.Name = "btnResizeImage";
            btnResizeImage.Size = new Size(309, 95);
            btnResizeImage.TabIndex = 11;
            btnResizeImage.Text = "Resize Current Folder Image";
            btnResizeImage.UseVisualStyleBackColor = true;
            btnResizeImage.Click += btnResizeImage_Click;
            // 
            // btnResizeAllImage
            // 
            btnResizeAllImage.Location = new Point(717, 181);
            btnResizeAllImage.Name = "btnResizeAllImage";
            btnResizeAllImage.Size = new Size(309, 95);
            btnResizeAllImage.TabIndex = 12;
            btnResizeAllImage.Text = "Resize Current Folder All Image";
            btnResizeAllImage.UseVisualStyleBackColor = true;
            btnResizeAllImage.Click += btnResizeAllImage_Click;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(44, 339);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(59, 25);
            lblFolder.TabIndex = 13;
            lblFolder.Text = "label1";
            // 
            // lstLogging
            // 
            lstLogging.FormattingEnabled = true;
            lstLogging.Location = new Point(27, 385);
            lstLogging.Name = "lstLogging";
            lstLogging.Size = new Size(1030, 279);
            lstLogging.TabIndex = 14;
            // 
            // btnClearLogging
            // 
            btnClearLogging.Location = new Point(882, 309);
            btnClearLogging.Name = "btnClearLogging";
            btnClearLogging.Size = new Size(144, 55);
            btnClearLogging.TabIndex = 15;
            btnClearLogging.Text = "Clear Logging";
            btnClearLogging.UseVisualStyleBackColor = true;
            btnClearLogging.Click += btnClearLogging_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 693);
            Controls.Add(btnClearLogging);
            Controls.Add(lstLogging);
            Controls.Add(lblFolder);
            Controls.Add(btnResizeAllImage);
            Controls.Add(btnResizeImage);
            Controls.Add(btnResaveAllImage);
            Controls.Add(btnResaveImage);
            Controls.Add(chkExitApp);
            Controls.Add(chkRemoveOriginalFile);
            Controls.Add(chkIgonreDateCheck);
            Controls.Add(numParallelCount);
            Controls.Add(numSizePercentage);
            Controls.Add(numJPGQuality);
            Controls.Add(lblParallelCount);
            Controls.Add(lblSizePercentage);
            Controls.Add(lblJPGQuality);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageTuner (JPG, PNG, BMP)";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numJPGQuality).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSizePercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numParallelCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJPGQuality;
        private Label lblSizePercentage;
        private Label lblParallelCount;
        private NumericUpDown numJPGQuality;
        private NumericUpDown numSizePercentage;
        private NumericUpDown numParallelCount;
        private CheckBox chkIgonreDateCheck;
        private CheckBox chkRemoveOriginalFile;
        private CheckBox chkExitApp;
        private Button btnResaveImage;
        private Button btnResaveAllImage;
        private Button btnResizeImage;
        private Button btnResizeAllImage;
        private Label lblFolder;
        private ListBox lstLogging;
        private Button btnClearLogging;
    }
}
