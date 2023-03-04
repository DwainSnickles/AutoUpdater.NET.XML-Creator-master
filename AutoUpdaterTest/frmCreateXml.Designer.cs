
namespace AutoUpdaterTest
{
    partial class frmCreateXml
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.ckbCustomMinVersion = new System.Windows.Forms.CheckBox();
            this.txtMinimunVersion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOpenXMLFile = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCreateXMLFile = new System.Windows.Forms.Button();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.rbMandatoryFalse = new System.Windows.Forms.RadioButton();
            this.rbMandatoryTrue = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtSaveToFolder = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtXmlFilename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChangelogURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCheckSum = new System.Windows.Forms.ComboBox();
            this.txtCheckSum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtNewVersion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtDownloadURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl5.SuspendLayout();
            this.pnl8.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.pnl7.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 44);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(267, 17);
            this.labelStatus.Text = "Enter new version number, Click next to continue";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 66);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::AutoUpdaterTest.Properties.Resources.Previous;
            this.btnBack.Location = new System.Drawing.Point(1, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::AutoUpdaterTest.Properties.Resources.Next1;
            this.btnNext.Location = new System.Drawing.Point(270, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnl5);
            this.splitContainer1.Panel2.Controls.Add(this.pnl8);
            this.splitContainer1.Panel2.Controls.Add(this.pnl4);
            this.splitContainer1.Panel2.Controls.Add(this.pnl7);
            this.splitContainer1.Panel2.Controls.Add(this.pnl3);
            this.splitContainer1.Panel2.Controls.Add(this.pnl6);
            this.splitContainer1.Panel2.Controls.Add(this.pnl1);
            this.splitContainer1.Panel2.Controls.Add(this.pnl2);
            this.splitContainer1.Size = new System.Drawing.Size(399, 164);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AutoUpdaterTest.Properties.Resources.AutoUpdateCloud;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 32);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Auto Updater ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 32);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xml Creator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl5.Controls.Add(this.ckbCustomMinVersion);
            this.pnl5.Controls.Add(this.txtMinimunVersion);
            this.pnl5.Controls.Add(this.label8);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl5.Location = new System.Drawing.Point(0, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(263, 164);
            this.pnl5.TabIndex = 5;
            // 
            // ckbCustomMinVersion
            // 
            this.ckbCustomMinVersion.AutoSize = true;
            this.ckbCustomMinVersion.Location = new System.Drawing.Point(7, 104);
            this.ckbCustomMinVersion.Name = "ckbCustomMinVersion";
            this.ckbCustomMinVersion.Size = new System.Drawing.Size(162, 17);
            this.ckbCustomMinVersion.TabIndex = 13;
            this.ckbCustomMinVersion.Text = "Use custom minimum version";
            this.ckbCustomMinVersion.UseVisualStyleBackColor = true;
            this.ckbCustomMinVersion.CheckedChanged += new System.EventHandler(this.ckbCustomMinVersion_CheckedChanged);
            // 
            // txtMinimunVersion
            // 
            this.txtMinimunVersion.Location = new System.Drawing.Point(7, 125);
            this.txtMinimunVersion.Name = "txtMinimunVersion";
            this.txtMinimunVersion.Size = new System.Drawing.Size(78, 20);
            this.txtMinimunVersion.TabIndex = 12;
            this.txtMinimunVersion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimunVersion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 90);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mandatory minimum version is optional. \r\nOnly used when mandatory download is use" +
    "d.\r\nyou can set the mandatory minimun vesion \r\nhere .\r\n\r\nProper format is 0.0.0." +
    "0 \r\n";
            // 
            // pnl8
            // 
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl8.Controls.Add(this.label17);
            this.pnl8.Controls.Add(this.btnOpenXMLFile);
            this.pnl8.Controls.Add(this.label16);
            this.pnl8.Controls.Add(this.btnCreateXMLFile);
            this.pnl8.Location = new System.Drawing.Point(178, 109);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(56, 43);
            this.pnl8.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "To Preview XML Click Button";
            // 
            // btnOpenXMLFile
            // 
            this.btnOpenXMLFile.Location = new System.Drawing.Point(43, 109);
            this.btnOpenXMLFile.Name = "btnOpenXMLFile";
            this.btnOpenXMLFile.Size = new System.Drawing.Size(99, 23);
            this.btnOpenXMLFile.TabIndex = 7;
            this.btnOpenXMLFile.Text = "Open XML File";
            this.btnOpenXMLFile.UseVisualStyleBackColor = true;
            this.btnOpenXMLFile.Click += new System.EventHandler(this.btnOpenXMLFile_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Click Create XML FIle";
            // 
            // btnCreateXMLFile
            // 
            this.btnCreateXMLFile.Location = new System.Drawing.Point(41, 35);
            this.btnCreateXMLFile.Name = "btnCreateXMLFile";
            this.btnCreateXMLFile.Size = new System.Drawing.Size(99, 23);
            this.btnCreateXMLFile.TabIndex = 5;
            this.btnCreateXMLFile.Text = "Create XML File";
            this.btnCreateXMLFile.UseVisualStyleBackColor = true;
            this.btnCreateXMLFile.Click += new System.EventHandler(this.btnCreateXMLFile_Click);
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.rbMandatoryFalse);
            this.pnl4.Controls.Add(this.rbMandatoryTrue);
            this.pnl4.Controls.Add(this.label7);
            this.pnl4.Location = new System.Drawing.Point(9, 50);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(48, 46);
            this.pnl4.TabIndex = 4;
            // 
            // rbMandatoryFalse
            // 
            this.rbMandatoryFalse.AutoSize = true;
            this.rbMandatoryFalse.Checked = true;
            this.rbMandatoryFalse.Location = new System.Drawing.Point(16, 94);
            this.rbMandatoryFalse.Name = "rbMandatoryFalse";
            this.rbMandatoryFalse.Size = new System.Drawing.Size(156, 17);
            this.rbMandatoryFalse.TabIndex = 8;
            this.rbMandatoryFalse.TabStop = true;
            this.rbMandatoryFalse.Text = "False, (Let end user decide)";
            this.rbMandatoryFalse.UseVisualStyleBackColor = true;
            this.rbMandatoryFalse.CheckedChanged += new System.EventHandler(this.rbMandatoryFalse_CheckedChanged);
            // 
            // rbMandatoryTrue
            // 
            this.rbMandatoryTrue.AutoSize = true;
            this.rbMandatoryTrue.Location = new System.Drawing.Point(16, 117);
            this.rbMandatoryTrue.Name = "rbMandatoryTrue";
            this.rbMandatoryTrue.Size = new System.Drawing.Size(178, 17);
            this.rbMandatoryTrue.TabIndex = 7;
            this.rbMandatoryTrue.Text = "True, (This update is Mandatory)";
            this.rbMandatoryTrue.UseVisualStyleBackColor = true;
            this.rbMandatoryTrue.CheckedChanged += new System.EventHandler(this.rbMandatoryTrue_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 75);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mandatory is optional. \r\nThe default is false which allows end user\r\nto Download," +
    " Skip or Remind them later.\r\n\r\nSelect True below to force an update.\r\n";
            // 
            // pnl7
            // 
            this.pnl7.Controls.Add(this.btnSelectFolder);
            this.pnl7.Controls.Add(this.txtSaveToFolder);
            this.pnl7.Controls.Add(this.label15);
            this.pnl7.Controls.Add(this.txtXmlFilename);
            this.pnl7.Controls.Add(this.label9);
            this.pnl7.Location = new System.Drawing.Point(88, 106);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(65, 45);
            this.pnl7.TabIndex = 8;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(216, 82);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtSaveToFolder
            // 
            this.txtSaveToFolder.Location = new System.Drawing.Point(13, 83);
            this.txtSaveToFolder.Name = "txtSaveToFolder";
            this.txtSaveToFolder.Size = new System.Drawing.Size(200, 20);
            this.txtSaveToFolder.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Select Save To Folder";
            // 
            // txtXmlFilename
            // 
            this.txtXmlFilename.Location = new System.Drawing.Point(13, 32);
            this.txtXmlFilename.Name = "txtXmlFilename";
            this.txtXmlFilename.Size = new System.Drawing.Size(168, 20);
            this.txtXmlFilename.TabIndex = 1;
            this.txtXmlFilename.Text = "MyAutoUpdate.xml";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enter XML filename:";
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl3.Controls.Add(this.label10);
            this.pnl3.Controls.Add(this.txtChangelogURL);
            this.pnl3.Controls.Add(this.label6);
            this.pnl3.Location = new System.Drawing.Point(152, 3);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(54, 47);
            this.pnl3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 52);
            this.label10.TabIndex = 6;
            this.label10.Text = "This is optional if URL is supplied, the html file will be \r\ndisplayed in the opt" +
    "ional download form.\r\n\r\nNot required if Mandatory download is to be used.";
            // 
            // txtChangelogURL
            // 
            this.txtChangelogURL.Location = new System.Drawing.Point(4, 127);
            this.txtChangelogURL.Name = "txtChangelogURL";
            this.txtChangelogURL.Size = new System.Drawing.Size(226, 20);
            this.txtChangelogURL.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 60);
            this.label6.TabIndex = 4;
            this.label6.Text = "Enter Changelog URL. \r\nDon\'t include index.html.\r\n\r\nExample: see in status window" +
    " below.\r\n";
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.Linen;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl6.Controls.Add(this.label14);
            this.pnl6.Controls.Add(this.cmbCheckSum);
            this.pnl6.Controls.Add(this.txtCheckSum);
            this.pnl6.Controls.Add(this.label12);
            this.pnl6.Controls.Add(this.label13);
            this.pnl6.Location = new System.Drawing.Point(134, 58);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(62, 35);
            this.pnl6.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Enter Checksum:";
            // 
            // cmbCheckSum
            // 
            this.cmbCheckSum.FormattingEnabled = true;
            this.cmbCheckSum.Items.AddRange(new object[] {
            "None",
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA51"});
            this.cmbCheckSum.Location = new System.Drawing.Point(6, 66);
            this.cmbCheckSum.Name = "cmbCheckSum";
            this.cmbCheckSum.Size = new System.Drawing.Size(64, 21);
            this.cmbCheckSum.TabIndex = 3;
            this.cmbCheckSum.Text = "None";
            // 
            // txtCheckSum
            // 
            this.txtCheckSum.Location = new System.Drawing.Point(7, 115);
            this.txtCheckSum.Name = "txtCheckSum";
            this.txtCheckSum.Size = new System.Drawing.Size(233, 20);
            this.txtCheckSum.TabIndex = 2;
            this.txtCheckSum.Text = "b10a8db164e0754105b7a99be72e3fe5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Select the checksum type.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Checksum (Optional): You can provide the \r\nchecksum for the update file";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Linen;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.txtNewVersion);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(67, 44);
            this.pnl1.TabIndex = 1;
            // 
            // txtNewVersion
            // 
            this.txtNewVersion.Location = new System.Drawing.Point(7, 112);
            this.txtNewVersion.Name = "txtNewVersion";
            this.txtNewVersion.Size = new System.Drawing.Size(93, 20);
            this.txtNewVersion.TabIndex = 2;
            this.txtNewVersion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewVersion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter new version. \r\nMust contain 4 digits with dots.\r\nexample 1.0.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Use this wizard to create your xml file for \r\nAutoUpdater.net";
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.txtDownloadURL);
            this.pnl2.Controls.Add(this.label5);
            this.pnl2.Location = new System.Drawing.Point(73, 3);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(65, 42);
            this.pnl2.TabIndex = 2;
            // 
            // txtDownloadURL
            // 
            this.txtDownloadURL.Location = new System.Drawing.Point(11, 111);
            this.txtDownloadURL.Name = "txtDownloadURL";
            this.txtDownloadURL.Size = new System.Drawing.Size(236, 20);
            this.txtDownloadURL.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 90);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter URL where new setup file \r\ncan be downloaded. \r\n\r\n\r\nExample:\r\nhttps://myweb" +
    "site.com/AutoUpdaterTest.zip";
            // 
            // frmCreateXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(399, 234);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCreateXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateXml";
            this.Load += new System.EventHandler(this.frmCreateXml_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl5.ResumeLayout(false);
            this.pnl5.PerformLayout();
            this.pnl8.ResumeLayout(false);
            this.pnl8.PerformLayout();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.pnl7.ResumeLayout(false);
            this.pnl7.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtNewVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.TextBox txtDownloadURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.TextBox txtChangelogURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.RadioButton rbMandatoryFalse;
        private System.Windows.Forms.RadioButton rbMandatoryTrue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinimunVersion;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCheckSum;
        private System.Windows.Forms.TextBox txtCheckSum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Button btnCreateXMLFile;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtSaveToFolder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtXmlFilename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnOpenXMLFile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox ckbCustomMinVersion;
    }
}