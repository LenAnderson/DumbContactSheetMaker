namespace DumbContactSheetMaker
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.numSheetWidth = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numThumbHeight = new System.Windows.Forms.NumericUpDown();
			this.chkCover = new System.Windows.Forms.CheckBox();
			this.chkLargeFirst = new System.Windows.Forms.CheckBox();
			this.grpCover = new System.Windows.Forms.GroupBox();
			this.btnCoverPathBrowse = new System.Windows.Forms.Button();
			this.txtCoverPath = new System.Windows.Forms.TextBox();
			this.chkCoverFirst = new System.Windows.Forms.CheckBox();
			this.dlgCoverPathBrowse = new System.Windows.Forms.OpenFileDialog();
			this.grpSize = new System.Windows.Forms.GroupBox();
			this.chkMaxNumThumbs = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numMaxNumThumbs = new System.Windows.Forms.NumericUpDown();
			this.grpTitle = new System.Windows.Forms.GroupBox();
			this.btnTitleFont = new System.Windows.Forms.Button();
			this.pnlTitleBgColor = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.rdoTitleCustom = new System.Windows.Forms.RadioButton();
			this.rdoTitleFolder = new System.Windows.Forms.RadioButton();
			this.chkTitle = new System.Windows.Forms.CheckBox();
			this.dlgTitleColor = new System.Windows.Forms.ColorDialog();
			this.dlgTitleFont = new System.Windows.Forms.FontDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFolder = new System.Windows.Forms.TextBox();
			this.btnFolderBrowse = new System.Windows.Forms.Button();
			this.chkRecursive = new System.Windows.Forms.CheckBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.prgProgress = new System.Windows.Forms.ProgressBar();
			this.txtProgress = new System.Windows.Forms.TextBox();
			this.grpOutput = new System.Windows.Forms.GroupBox();
			this.btnOutputFolderBrowse = new System.Windows.Forms.Button();
			this.txtOutputFolder = new System.Windows.Forms.TextBox();
			this.rdoOutputFolder = new System.Windows.Forms.RadioButton();
			this.rdoOutputRoot = new System.Windows.Forms.RadioButton();
			this.rdoOutputImgFolder = new System.Windows.Forms.RadioButton();
			this.dlgOutputFolderPath = new System.Windows.Forms.OpenFileDialog();
			this.dlgFolderBrowse = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.numSheetWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numThumbHeight)).BeginInit();
			this.grpCover.SuspendLayout();
			this.grpSize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumThumbs)).BeginInit();
			this.grpTitle.SuspendLayout();
			this.grpOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contact Sheet Width (px):";
			// 
			// numSheetWidth
			// 
			this.numSheetWidth.Location = new System.Drawing.Point(159, 19);
			this.numSheetWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numSheetWidth.Name = "numSheetWidth";
			this.numSheetWidth.Size = new System.Drawing.Size(60, 20);
			this.numSheetWidth.TabIndex = 1;
			this.numSheetWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSheetWidth.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Max Thumb Height (px):";
			// 
			// numThumbHeight
			// 
			this.numThumbHeight.Location = new System.Drawing.Point(159, 45);
			this.numThumbHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numThumbHeight.Name = "numThumbHeight";
			this.numThumbHeight.Size = new System.Drawing.Size(60, 20);
			this.numThumbHeight.TabIndex = 3;
			this.numThumbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numThumbHeight.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// chkCover
			// 
			this.chkCover.AutoSize = true;
			this.chkCover.Location = new System.Drawing.Point(6, 19);
			this.chkCover.Name = "chkCover";
			this.chkCover.Size = new System.Drawing.Size(108, 17);
			this.chkCover.TabIndex = 4;
			this.chkCover.Text = "Add Cover Image";
			this.chkCover.UseVisualStyleBackColor = true;
			this.chkCover.CheckedChanged += new System.EventHandler(this.chkCover_CheckedChanged);
			// 
			// chkLargeFirst
			// 
			this.chkLargeFirst.AutoSize = true;
			this.chkLargeFirst.Checked = true;
			this.chkLargeFirst.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkLargeFirst.Location = new System.Drawing.Point(6, 98);
			this.chkLargeFirst.Name = "chkLargeFirst";
			this.chkLargeFirst.Size = new System.Drawing.Size(169, 17);
			this.chkLargeFirst.TabIndex = 5;
			this.chkLargeFirst.Text = "Large First Image (fills first row)";
			this.chkLargeFirst.UseVisualStyleBackColor = true;
			// 
			// grpCover
			// 
			this.grpCover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpCover.Controls.Add(this.btnCoverPathBrowse);
			this.grpCover.Controls.Add(this.txtCoverPath);
			this.grpCover.Controls.Add(this.chkCoverFirst);
			this.grpCover.Controls.Add(this.chkCover);
			this.grpCover.Location = new System.Drawing.Point(12, 324);
			this.grpCover.Name = "grpCover";
			this.grpCover.Size = new System.Drawing.Size(537, 100);
			this.grpCover.TabIndex = 6;
			this.grpCover.TabStop = false;
			this.grpCover.Text = "Cover Image";
			// 
			// btnCoverPathBrowse
			// 
			this.btnCoverPathBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCoverPathBrowse.Enabled = false;
			this.btnCoverPathBrowse.Location = new System.Drawing.Point(456, 65);
			this.btnCoverPathBrowse.Name = "btnCoverPathBrowse";
			this.btnCoverPathBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnCoverPathBrowse.TabIndex = 7;
			this.btnCoverPathBrowse.Text = "Browse...";
			this.btnCoverPathBrowse.UseVisualStyleBackColor = true;
			this.btnCoverPathBrowse.Click += new System.EventHandler(this.btnCoverPathBrowse_Click);
			// 
			// txtCoverPath
			// 
			this.txtCoverPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCoverPath.Location = new System.Drawing.Point(7, 67);
			this.txtCoverPath.Name = "txtCoverPath";
			this.txtCoverPath.ReadOnly = true;
			this.txtCoverPath.Size = new System.Drawing.Size(443, 20);
			this.txtCoverPath.TabIndex = 6;
			// 
			// chkCoverFirst
			// 
			this.chkCoverFirst.AutoSize = true;
			this.chkCoverFirst.Checked = true;
			this.chkCoverFirst.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCoverFirst.Enabled = false;
			this.chkCoverFirst.Location = new System.Drawing.Point(6, 42);
			this.chkCoverFirst.Name = "chkCoverFirst";
			this.chkCoverFirst.Size = new System.Drawing.Size(92, 17);
			this.chkCoverFirst.TabIndex = 5;
			this.chkCoverFirst.Text = "As First Image";
			this.chkCoverFirst.UseVisualStyleBackColor = true;
			// 
			// grpSize
			// 
			this.grpSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpSize.Controls.Add(this.chkMaxNumThumbs);
			this.grpSize.Controls.Add(this.label6);
			this.grpSize.Controls.Add(this.numMaxNumThumbs);
			this.grpSize.Controls.Add(this.label1);
			this.grpSize.Controls.Add(this.numSheetWidth);
			this.grpSize.Controls.Add(this.chkLargeFirst);
			this.grpSize.Controls.Add(this.label2);
			this.grpSize.Controls.Add(this.numThumbHeight);
			this.grpSize.Location = new System.Drawing.Point(12, 195);
			this.grpSize.Name = "grpSize";
			this.grpSize.Size = new System.Drawing.Size(537, 123);
			this.grpSize.TabIndex = 7;
			this.grpSize.TabStop = false;
			this.grpSize.Text = "Size";
			// 
			// chkMaxNumThumbs
			// 
			this.chkMaxNumThumbs.AutoSize = true;
			this.chkMaxNumThumbs.Location = new System.Drawing.Point(137, 74);
			this.chkMaxNumThumbs.Name = "chkMaxNumThumbs";
			this.chkMaxNumThumbs.Size = new System.Drawing.Size(15, 14);
			this.chkMaxNumThumbs.TabIndex = 8;
			this.chkMaxNumThumbs.UseVisualStyleBackColor = true;
			this.chkMaxNumThumbs.CheckedChanged += new System.EventHandler(this.chkMaxNumThumbs_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Max Number Of Thumbs:";
			// 
			// numMaxNumThumbs
			// 
			this.numMaxNumThumbs.Enabled = false;
			this.numMaxNumThumbs.Location = new System.Drawing.Point(159, 72);
			this.numMaxNumThumbs.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numMaxNumThumbs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMaxNumThumbs.Name = "numMaxNumThumbs";
			this.numMaxNumThumbs.Size = new System.Drawing.Size(60, 20);
			this.numMaxNumThumbs.TabIndex = 6;
			this.numMaxNumThumbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numMaxNumThumbs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// grpTitle
			// 
			this.grpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpTitle.Controls.Add(this.btnTitleFont);
			this.grpTitle.Controls.Add(this.pnlTitleBgColor);
			this.grpTitle.Controls.Add(this.label4);
			this.grpTitle.Controls.Add(this.label3);
			this.grpTitle.Controls.Add(this.txtTitle);
			this.grpTitle.Controls.Add(this.rdoTitleCustom);
			this.grpTitle.Controls.Add(this.rdoTitleFolder);
			this.grpTitle.Controls.Add(this.chkTitle);
			this.grpTitle.Location = new System.Drawing.Point(12, 430);
			this.grpTitle.Name = "grpTitle";
			this.grpTitle.Size = new System.Drawing.Size(537, 120);
			this.grpTitle.TabIndex = 8;
			this.grpTitle.TabStop = false;
			this.grpTitle.Text = "Title";
			// 
			// btnTitleFont
			// 
			this.btnTitleFont.Location = new System.Drawing.Point(43, 86);
			this.btnTitleFont.Name = "btnTitleFont";
			this.btnTitleFont.Size = new System.Drawing.Size(75, 23);
			this.btnTitleFont.TabIndex = 10;
			this.btnTitleFont.Text = "Change...";
			this.btnTitleFont.UseVisualStyleBackColor = true;
			this.btnTitleFont.Click += new System.EventHandler(this.btnTitleFont_Click);
			// 
			// pnlTitleBgColor
			// 
			this.pnlTitleBgColor.BackColor = System.Drawing.Color.Black;
			this.pnlTitleBgColor.Location = new System.Drawing.Point(107, 68);
			this.pnlTitleBgColor.Name = "pnlTitleBgColor";
			this.pnlTitleBgColor.Size = new System.Drawing.Size(12, 12);
			this.pnlTitleBgColor.TabIndex = 5;
			this.pnlTitleBgColor.Click += new System.EventHandler(this.pnlTitleBgColor_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Font:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Background Color:";
			// 
			// txtTitle
			// 
			this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTitle.Enabled = false;
			this.txtTitle.Location = new System.Drawing.Point(209, 42);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(322, 20);
			this.txtTitle.TabIndex = 3;
			// 
			// rdoTitleCustom
			// 
			this.rdoTitleCustom.AutoSize = true;
			this.rdoTitleCustom.Location = new System.Drawing.Point(120, 43);
			this.rdoTitleCustom.Name = "rdoTitleCustom";
			this.rdoTitleCustom.Size = new System.Drawing.Size(86, 17);
			this.rdoTitleCustom.TabIndex = 2;
			this.rdoTitleCustom.Text = "Custom Title:";
			this.rdoTitleCustom.UseVisualStyleBackColor = true;
			this.rdoTitleCustom.CheckedChanged += new System.EventHandler(this.rdoTitleCustom_CheckedChanged);
			// 
			// rdoTitleFolder
			// 
			this.rdoTitleFolder.AutoSize = true;
			this.rdoTitleFolder.Checked = true;
			this.rdoTitleFolder.Location = new System.Drawing.Point(6, 43);
			this.rdoTitleFolder.Name = "rdoTitleFolder";
			this.rdoTitleFolder.Size = new System.Drawing.Size(107, 17);
			this.rdoTitleFolder.TabIndex = 1;
			this.rdoTitleFolder.TabStop = true;
			this.rdoTitleFolder.Text = "Use Folder Name";
			this.rdoTitleFolder.UseVisualStyleBackColor = true;
			// 
			// chkTitle
			// 
			this.chkTitle.AutoSize = true;
			this.chkTitle.Checked = true;
			this.chkTitle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTitle.Location = new System.Drawing.Point(6, 19);
			this.chkTitle.Name = "chkTitle";
			this.chkTitle.Size = new System.Drawing.Size(76, 17);
			this.chkTitle.TabIndex = 0;
			this.chkTitle.Text = "Show Title";
			this.chkTitle.UseVisualStyleBackColor = true;
			this.chkTitle.CheckedChanged += new System.EventHandler(this.chkTitle_CheckedChanged);
			// 
			// dlgTitleFont
			// 
			this.dlgTitleFont.Color = System.Drawing.Color.White;
			this.dlgTitleFont.ShowColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Folder:";
			// 
			// txtFolder
			// 
			this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFolder.Location = new System.Drawing.Point(57, 14);
			this.txtFolder.Name = "txtFolder";
			this.txtFolder.ReadOnly = true;
			this.txtFolder.Size = new System.Drawing.Size(411, 20);
			this.txtFolder.TabIndex = 10;
			// 
			// btnFolderBrowse
			// 
			this.btnFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFolderBrowse.Location = new System.Drawing.Point(474, 12);
			this.btnFolderBrowse.Name = "btnFolderBrowse";
			this.btnFolderBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnFolderBrowse.TabIndex = 11;
			this.btnFolderBrowse.Text = "Browse...";
			this.btnFolderBrowse.UseVisualStyleBackColor = true;
			this.btnFolderBrowse.Click += new System.EventHandler(this.btnFolderBrowse_Click);
			// 
			// chkRecursive
			// 
			this.chkRecursive.AutoSize = true;
			this.chkRecursive.Location = new System.Drawing.Point(12, 40);
			this.chkRecursive.Name = "chkRecursive";
			this.chkRecursive.Size = new System.Drawing.Size(278, 17);
			this.chkRecursive.TabIndex = 12;
			this.chkRecursive.Text = "Recursive (create a contact sheet for each subfolder)";
			this.chkRecursive.UseVisualStyleBackColor = true;
			this.chkRecursive.CheckedChanged += new System.EventHandler(this.chkRecursive_CheckedChanged);
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(12, 63);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 13;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// prgProgress
			// 
			this.prgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.prgProgress.Location = new System.Drawing.Point(93, 63);
			this.prgProgress.Name = "prgProgress";
			this.prgProgress.Size = new System.Drawing.Size(236, 23);
			this.prgProgress.Step = 1;
			this.prgProgress.TabIndex = 14;
			// 
			// txtProgress
			// 
			this.txtProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProgress.Location = new System.Drawing.Point(335, 65);
			this.txtProgress.Name = "txtProgress";
			this.txtProgress.ReadOnly = true;
			this.txtProgress.Size = new System.Drawing.Size(217, 20);
			this.txtProgress.TabIndex = 15;
			// 
			// grpOutput
			// 
			this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpOutput.Controls.Add(this.btnOutputFolderBrowse);
			this.grpOutput.Controls.Add(this.txtOutputFolder);
			this.grpOutput.Controls.Add(this.rdoOutputFolder);
			this.grpOutput.Controls.Add(this.rdoOutputRoot);
			this.grpOutput.Controls.Add(this.rdoOutputImgFolder);
			this.grpOutput.Location = new System.Drawing.Point(12, 93);
			this.grpOutput.Name = "grpOutput";
			this.grpOutput.Size = new System.Drawing.Size(537, 96);
			this.grpOutput.TabIndex = 16;
			this.grpOutput.TabStop = false;
			this.grpOutput.Text = "Output Folder";
			// 
			// btnOutputFolderBrowse
			// 
			this.btnOutputFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOutputFolderBrowse.Enabled = false;
			this.btnOutputFolderBrowse.Location = new System.Drawing.Point(456, 63);
			this.btnOutputFolderBrowse.Name = "btnOutputFolderBrowse";
			this.btnOutputFolderBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnOutputFolderBrowse.TabIndex = 12;
			this.btnOutputFolderBrowse.Text = "Browse...";
			this.btnOutputFolderBrowse.UseVisualStyleBackColor = true;
			this.btnOutputFolderBrowse.Click += new System.EventHandler(this.btnOutputFolderBrowse_Click);
			// 
			// txtOutputFolder
			// 
			this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutputFolder.Enabled = false;
			this.txtOutputFolder.Location = new System.Drawing.Point(69, 65);
			this.txtOutputFolder.Name = "txtOutputFolder";
			this.txtOutputFolder.ReadOnly = true;
			this.txtOutputFolder.Size = new System.Drawing.Size(381, 20);
			this.txtOutputFolder.TabIndex = 11;
			// 
			// rdoOutputFolder
			// 
			this.rdoOutputFolder.AutoSize = true;
			this.rdoOutputFolder.Location = new System.Drawing.Point(6, 66);
			this.rdoOutputFolder.Name = "rdoOutputFolder";
			this.rdoOutputFolder.Size = new System.Drawing.Size(57, 17);
			this.rdoOutputFolder.TabIndex = 2;
			this.rdoOutputFolder.Text = "Folder:";
			this.rdoOutputFolder.UseVisualStyleBackColor = true;
			this.rdoOutputFolder.CheckedChanged += new System.EventHandler(this.rdoOutput_CheckedChanged);
			// 
			// rdoOutputRoot
			// 
			this.rdoOutputRoot.AutoSize = true;
			this.rdoOutputRoot.Enabled = false;
			this.rdoOutputRoot.Location = new System.Drawing.Point(6, 43);
			this.rdoOutputRoot.Name = "rdoOutputRoot";
			this.rdoOutputRoot.Size = new System.Drawing.Size(80, 17);
			this.rdoOutputRoot.TabIndex = 1;
			this.rdoOutputRoot.Text = "Root Folder";
			this.rdoOutputRoot.UseVisualStyleBackColor = true;
			this.rdoOutputRoot.CheckedChanged += new System.EventHandler(this.rdoOutput_CheckedChanged);
			// 
			// rdoOutputImgFolder
			// 
			this.rdoOutputImgFolder.AutoSize = true;
			this.rdoOutputImgFolder.Checked = true;
			this.rdoOutputImgFolder.Location = new System.Drawing.Point(6, 20);
			this.rdoOutputImgFolder.Name = "rdoOutputImgFolder";
			this.rdoOutputImgFolder.Size = new System.Drawing.Size(86, 17);
			this.rdoOutputImgFolder.TabIndex = 0;
			this.rdoOutputImgFolder.TabStop = true;
			this.rdoOutputImgFolder.Text = "Image Folder";
			this.rdoOutputImgFolder.UseVisualStyleBackColor = true;
			this.rdoOutputImgFolder.CheckedChanged += new System.EventHandler(this.rdoOutput_CheckedChanged);
			// 
			// dlgOutputFolderPath
			// 
			this.dlgOutputFolderPath.CheckFileExists = false;
			this.dlgOutputFolderPath.FileName = "Folder Selection";
			this.dlgOutputFolderPath.ValidateNames = false;
			// 
			// dlgFolderBrowse
			// 
			this.dlgFolderBrowse.FileName = "Folder Selection";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 559);
			this.Controls.Add(this.grpOutput);
			this.Controls.Add(this.txtProgress);
			this.Controls.Add(this.prgProgress);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.chkRecursive);
			this.Controls.Add(this.btnFolderBrowse);
			this.Controls.Add(this.txtFolder);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.grpTitle);
			this.Controls.Add(this.grpSize);
			this.Controls.Add(this.grpCover);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(580, 520);
			this.Name = "MainForm";
			this.Text = "Dumb Contact Sheet Maker";
			((System.ComponentModel.ISupportInitialize)(this.numSheetWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numThumbHeight)).EndInit();
			this.grpCover.ResumeLayout(false);
			this.grpCover.PerformLayout();
			this.grpSize.ResumeLayout(false);
			this.grpSize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxNumThumbs)).EndInit();
			this.grpTitle.ResumeLayout(false);
			this.grpTitle.PerformLayout();
			this.grpOutput.ResumeLayout(false);
			this.grpOutput.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSheetWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numThumbHeight;
        private System.Windows.Forms.CheckBox chkCover;
        private System.Windows.Forms.CheckBox chkLargeFirst;
        private System.Windows.Forms.GroupBox grpCover;
        private System.Windows.Forms.Button btnCoverPathBrowse;
        private System.Windows.Forms.TextBox txtCoverPath;
        private System.Windows.Forms.CheckBox chkCoverFirst;
        private System.Windows.Forms.OpenFileDialog dlgCoverPathBrowse;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.Panel pnlTitleBgColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RadioButton rdoTitleCustom;
        private System.Windows.Forms.RadioButton rdoTitleFolder;
        private System.Windows.Forms.CheckBox chkTitle;
        private System.Windows.Forms.ColorDialog dlgTitleColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FontDialog dlgTitleFont;
        private System.Windows.Forms.Button btnTitleFont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.CheckBox chkMaxNumThumbs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMaxNumThumbs;
		private System.Windows.Forms.GroupBox grpOutput;
		private System.Windows.Forms.Button btnOutputFolderBrowse;
		private System.Windows.Forms.TextBox txtOutputFolder;
		private System.Windows.Forms.RadioButton rdoOutputFolder;
		private System.Windows.Forms.RadioButton rdoOutputRoot;
		private System.Windows.Forms.RadioButton rdoOutputImgFolder;
		private System.Windows.Forms.OpenFileDialog dlgOutputFolderPath;
		private System.Windows.Forms.OpenFileDialog dlgFolderBrowse;
	}
}

