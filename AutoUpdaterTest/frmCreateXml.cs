using AutoUpdaterTest.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoUpdaterTest
{
    public partial class frmCreateXml : Form
    {
        public frmCreateXml()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Keeps track of current page
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Added the updater class to hold variables
        /// this class will hold all items to be added to XML file
        /// </summary>
        private AutoUpdateXMLitems xMLitems = new AutoUpdateXMLitems();

        public string UpdateFilePath { get; set; }

        private ChecksumUtil checksum = new ChecksumUtil();

        private void frmCreateXml_Load(object sender, EventArgs e)
        {
            //set default mandatory type pnl3 will change as needed
            xMLitems.MandatoryType = AutoUpdateXMLitems.MandatoryTypes.Not_Mandatory;
            xMLitems.mandatory = false;
            btnNext.Enabled = false;
            DisplayPanel(1);
        }

        #region Pnl 1 Controls

        private void txtNewVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //omly allow digits and dots
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtNewVersion_TextChanged(object sender, EventArgs e)
        {
            string str = txtNewVersion.Text;

            //make sure if entered manually it contains 3 dots .... and minimum of 4 digits
            //Enforce version requirement
            int dots = txtNewVersion.Text.Count(c => c == '.');
            int digits = txtNewVersion.Text.Count(c => Char.IsNumber(c));

            if (txtNewVersion.Text == string.Empty)
            {
                picVersionStatus.Image = Properties.Resources.RedX;
                xMLitems.version = string.Empty;
                btnNext.Enabled = false;
            }
            else 
            {
                if (dots == 3 && digits == 4)
                {
                    picVersionStatus.Image = Properties.Resources.G_Check;
                    xMLitems.version = txtNewVersion.Text;
                    btnNext.Enabled = true;
                }
                else
                {
                    picVersionStatus.Image = Properties.Resources.RedX;
                    xMLitems.version = string.Empty;
                    btnNext.Enabled = false;
                }
                   
            }
        }
        #endregion
        #region panl 2 Controls

        private void txtDownloadURL_TextChanged(object sender, EventArgs e)
        {
            if (txtDownloadURL.Text != string.Empty)
            {
                xMLitems.UpdateFilePath = txtDownloadURL.Text;
                picDownloadURL.Image = Properties.Resources.G_Check;
                btnNext.Enabled = true;
                xMLitems.downLoadurl = txtDownloadURL.Text;
            }
            else
            {
                picDownloadURL.Image = Properties.Resources.RedX;
                btnNext.Enabled = false;
                xMLitems.downLoadurl = string.Empty;
            }
                
        }

        #endregion
        #region pnl 3 Controls

        private void reSetMandatoryOptions()
        {
            xMLitems.mandatory = false;
            xMLitems.mandatoryOption1 = false;
            xMLitems.mandatoryOption2 = false;
            xMLitems.mandatory_minVersion = false;
        }

        /// <summary>
        /// Enable disable next button ensuring that a least one update type is selected
        /// </summary>
        private void CheckRbUpdateModeType()
        {
            btnNext.Enabled = false;

            if (rbMandatory.Checked || rbMandatoryMinimumVersion.Checked || rbMandatoryMode1.Checked || rbMandatoryMode2.Checked)
            {
                btnNext.Enabled = true;
            }
        }

        private void rbOptionalUpdate_CheckedChanged(object sender, EventArgs e)
        {
            reSetMandatoryOptions();
            CheckRbUpdateModeType();

            if (rbOptionalUpdate.Checked)
            {
                pnlChangelog.Visible = true;
                pnlChangelog.Dock = DockStyle.Fill;
                pnlChangelog.BringToFront();
                btnNext.Enabled = true;
                xMLitems.MandatoryType = AutoUpdateXMLitems.MandatoryTypes.Not_Mandatory;
            }

            if (txtChangelogURL.Text != string.Empty)
            {
                xMLitems.changelogurl = txtChangelogURL.Text;
            }
        }

        private void rbMandatory_CheckedChanged(object sender, EventArgs e)
        {
            reSetMandatoryOptions();
            CheckRbUpdateModeType();

            if (rbMandatory.Checked)
            {
                xMLitems.MandatoryType = AutoUpdateXMLitems.MandatoryTypes.Mandatory;
                xMLitems.mandatory = true;
            }
        }

        private void rbMandatoryMinimumVersion_CheckedChanged(object sender, EventArgs e)
        {
            reSetMandatoryOptions();
            CheckRbUpdateModeType();

            if (rbMandatoryMinimumVersion.Checked)
            {
                pnlSetMinversion.Visible = true;
                pnlSetMinversion.Dock = DockStyle.Fill;
                pnlSetMinversion.BringToFront();
                rbMandatoryMinimumVersion.Checked = false;
                xMLitems.MandatoryType = AutoUpdateXMLitems.MandatoryTypes.MandatoryMinVersion;
            }
            if (txtMinVersion.Text != string.Empty)
            {
                xMLitems.mandatory_minVersion = true;
            }
        }

        private void rbMandatoryMode2_CheckedChanged(object sender, EventArgs e)
        {
            reSetMandatoryOptions();
            CheckRbUpdateModeType();

            if (rbMandatoryMode2.Checked)
            {
                xMLitems.MandatoryType = AutoUpdateXMLitems.MandatoryTypes.MandatoryOption2;
                xMLitems.mandatoryOption2 = true;
            }
        }

        private void rbMandatoryMode1_CheckedChanged(object sender, EventArgs e)
        {
            reSetMandatoryOptions();
            CheckRbUpdateModeType();

            if (rbMandatoryMode1.Checked)
            {
                xMLitems.MandatoryType = AutoUpdateXMLitems.MandatoryTypes.MandatoryOption1;
                xMLitems.mandatoryOption1 = true;
            }
        }

        #endregion
        #region pnl 4 Controls
 
        private void cmbCheckSum_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCheckSum.SelectedIndex)
            {
                case 0:
                    //xMLitems.AlgoritmmType 
                    xMLitems.AlgoritmType = AutoUpdateXMLitems.HashingAlgoTypes.None;
                    ChecksumUtil.AlgorithmType = ChecksumUtil.HashingAlgoTypes.None;
                    break;

                case 1:
                     xMLitems.AlgoritmType = AutoUpdateXMLitems.HashingAlgoTypes.MD5;
                    ChecksumUtil.AlgorithmType = ChecksumUtil.HashingAlgoTypes.MD5;
                    break;

                case 2:
                    xMLitems.AlgoritmType = AutoUpdateXMLitems.HashingAlgoTypes.SHA1;
                    ChecksumUtil.AlgorithmType = ChecksumUtil.HashingAlgoTypes.SHA1;
                    break;

                case 3:
                    xMLitems.AlgoritmType = AutoUpdateXMLitems.HashingAlgoTypes.SHA256;
                    ChecksumUtil.AlgorithmType = ChecksumUtil.HashingAlgoTypes.SHA256;
                    break;

                case 4:
                    xMLitems.AlgoritmType = AutoUpdateXMLitems.HashingAlgoTypes.SHA384;
                    ChecksumUtil.AlgorithmType = ChecksumUtil.HashingAlgoTypes.SHA384;
                    break;

                case 5:
                    xMLitems.AlgoritmType = AutoUpdateXMLitems.HashingAlgoTypes.SHA512;
                    ChecksumUtil.AlgorithmType = ChecksumUtil.HashingAlgoTypes.SHA512;
                    break;

                default:
                    xMLitems.AlgoritmType = AutoUpdateXMLitems.HashingAlgoTypes.None;
                    break;
            }
        }

        private void btnBrowseExeFile_Click(object sender, EventArgs e)
        {
            // Browse for setup file to get checksum
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.FileName != string.Empty)
            {
                txtDownloadableFile.Text = ofd.FileName;
                //Process.Start(ofd.FileName);
            }
        }

        private void btnCalculateChecksum_Click(object sender, EventArgs e)
        {
            txtCheckSum.Text = string.Empty;
            xMLitems.checksum = string.Empty;

            if (txtDownloadableFile.Text != string.Empty && cmbCheckSum.SelectedIndex > 0)
            {
                txtCheckSum.Text = ChecksumUtil.GetChecksum(ChecksumUtil.AlgorithmType, txtDownloadableFile.Text);
                xMLitems.checksum = txtCheckSum.Text;
            }
        }

        private void txtCheckSum_TextChanged(object sender, EventArgs e)
        {
            xMLitems.checksum = string.Empty;

            if (txtCheckSum.Text != string.Empty)
            {
                xMLitems.checksum = txtCheckSum.Text;
            }
        }

        private void btnNextPrevVersion_Click(object sender, EventArgs e)
        {
            if (Page == 6) { btnNext.Enabled = false; return; }
            Page++;
            DisplayPanel(Page);
        }

        #endregion
        #region pnl 5

        private void txtCommandLineArgs_TextChanged_1(object sender, EventArgs e)
        {
            xMLitems.CommandLineArgs = txtCommandLineArgs.Text;
        }
        #endregion
        #region Pnl 6 and 6A Controls

        private void txtXmlFilename_TextChanged(object sender, EventArgs e)
        {
            xMLitems.xmlFileName = string.Empty;

            if (txtXmlFilename.Text != string.Empty)
            {
                xMLitems.xmlFileName = txtXmlFilename.Text;

                if (!xMLitems.xmlFileName.EndsWith(".xml"))
                {
                    xMLitems.xmlFileName += ".xml";
                }
            }
        }

        private void txtSaveToFolder_TextChanged(object sender, EventArgs e)
        {
            xMLitems.xmlFolderPath = string.Empty;

            if (txtSaveToFolder.Text != string.Empty)
            {
                xMLitems.xmlFolderPath = txtSaveToFolder.Text;
            }
        }

        private void btnOpenXmlFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtSaveToFolder.Text = fbd.SelectedPath + "\\";
            xMLitems.xmlFolderPath = txtSaveToFolder.Text;
        }

        private void btnCreateXMLFile_Click(object sender, EventArgs e)
        {
            if (txtXmlFilename.Text != string.Empty && txtSaveToFolder.Text != string.Empty)
            {
                createXML(); 
                //pnl6A.Visible = true;
                //pnl6.BringToFront();
                //pnl6A.Dock = DockStyle.Bottom;
            }
            else { MessageBox.Show("Both answers are required. Please try again", "Can't Write XML"); pnl6A.Visible = false; }
        }

        private void btnOpenXmlFolder_Click_1(object sender, EventArgs e)
        {
            if (xMLitems.xmlFolderPath != string.Empty)
            {
                Process.Start(xMLitems.xmlFolderPath);

            }
        }

        private void btnOpenXMLFile_Click_1(object sender, EventArgs e)
        {
            if (xMLitems.xmlFolderPath != string.Empty && xMLitems.xmlFileName != string.Empty)
            {
                Process.Start(xMLitems.xmlFolderPath + xMLitems.xmlFileName);
            }
        }

        #endregion
        #region pnl SetMinversion

        private void btnPrevMinVersion_Click(object sender, EventArgs e)
        {
            pnlSetMinversion.Visible = false;
            //CheckRbUpdateModeType();
        }

        private void txtMinVersion_TextChanged(object sender, EventArgs e)
        {
            string str = txtMinVersion.Text;

            //make sure if entered manually it contains 3 dots .... and minimum of 4 digits
            //Enforce version requirement
            int dots = txtMinVersion.Text.Count(c => c == '.');
            int digits = txtMinVersion.Text.Count(c => Char.IsNumber(c));

            if (txtMinVersion.Text == string.Empty)
            {
                picMinVersion.Image = Properties.Resources.RedX;
                xMLitems.minVersion = string.Empty;
                btnPrevMinVersion.Visible = true;
                btnNextPrevVersion.Visible = false;
            }
            else
            {
                if (dots == 3 && digits == 4)
                {
                    picMinVersion.Image = Properties.Resources.G_Check;
                    xMLitems.minVersion = txtMinVersion.Text;
                    btnNext.Enabled = true;
                    btnPrevMinVersion.Visible = false;
                    btnNextPrevVersion.Visible = true;
                }
                else
                {
                    picMinVersion.Image = Properties.Resources.RedX;
                    xMLitems.minVersion = string.Empty;
                    btnPrevMinVersion.Visible = true;
                    btnNextPrevVersion.Visible = false;
                }
            }
        }

        private void txtMinimunVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //omly allow digits and dots
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        #endregion
        #region pnlChangelog
  
        private void txtChangelogURL_TextChanged(object sender, EventArgs e)
        {
            //must update autoupdatexml class
            xMLitems.changelogurl = txtChangelogURL.Text.Trim();
        }

        #endregion
        #region Bottom panel buttons Previous Next Exit

        /// <summary>
        /// Advance to next panel eg pnl1 - pnl6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Page == 6) { btnNext.Enabled = false; return; }
            Page++;
            DisplayPanel(Page);
        }

        /// <summary>
        /// Allow user to go back if needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Page == 1) { return; }
            Page--;
            DisplayPanel(Page);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close XML Creator?", "Confim Closing XML Creator", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //don't do anything
            }
        }

        #endregion

        /// <summary>
        /// Undocks all Panels, Displays and docks panels based on page number
        /// </summary>
        /// <param name="PanelNumber"></param>
        private void DisplayPanel(int PanelNumber)
        {

            if (Page == 6)
            {
                btnNext.Enabled = false;
            }
            else { btnNext.Enabled = true; }

            //minimize all panels and reset dockstyle
            this.pnl1.Dock = System.Windows.Forms.DockStyle.None;
            this.pnl2.Dock = System.Windows.Forms.DockStyle.None;
            this.pnl3.Dock = System.Windows.Forms.DockStyle.None;
            this.pnl4.Dock = System.Windows.Forms.DockStyle.None;
            this.pnl5.Dock = System.Windows.Forms.DockStyle.None;
            this.pnl6.Dock = System.Windows.Forms.DockStyle.None;
            this.pnl6A.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlChangelog.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlSetMinversion.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlChangelog.Visible = false;
            this.pnlSetMinversion.Visible = false;

            String XMLFilePath = AppDomain.CurrentDomain.BaseDirectory + "XMLFile1.xml";

            switch (PanelNumber)
            {
                case 1:
                    if (txtNewVersion.Text == string.Empty)
                    {
                        btnNext.Enabled = false;
                    }
                    this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Enter new version number, Click next to continue";
                    pnl1.BringToFront();
                    this.ActiveControl = txtNewVersion;
                    break;

                case 2:

                    btnNext.Enabled = false;

                    if (Page == 2 && txtDownloadURL.Text != string.Empty)
                    {
                        btnNext.Enabled = true;
                    }

                    this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Example https://rbsoft.org/downloads/AutoUpdaterTest.zip";
                    pnl2.BringToFront();
                    this.ActiveControl = txtDownloadURL;

                    break;

                case 3:

                    btnNext.Enabled = false;
                    this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Example https://github.com/AutoUpdater.NET/releases";
                    pnl3.BringToFront();
                    break;

                case 4:

                    this.pnl4.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Optional, Select Checksum type and enter Checksum value";
                    pnl4.BringToFront();
                    break;

                case 5: //Create xml 

                    this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Optional commandline args. Click next to skip";
                    pnl5.BringToFront();
                    break;

                case 6: //Review XML
                    this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Enter XML file name and click next to continue";
                    pnl6A.Dock = DockStyle.Bottom;
                    pnl6.BringToFront();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Create the xml file to be used for Autoupdate
        /// </summary>
        private void createXML()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                //XmlDeclaration xml_declaration;
                XmlDeclaration xml_declaration;
                xml_declaration = xmlDoc.CreateXmlDeclaration("1.0", "ISO-8859-1", "yes");
                XmlElement document_element = xmlDoc.DocumentElement;
                xmlDoc.InsertBefore(xml_declaration, document_element);
                xmlDoc.AppendChild(xml_declaration);

                XmlNode rootNode = xmlDoc.CreateElement("item");
                xmlDoc.AppendChild(rootNode);

                XmlNode userNodeVersion = xmlDoc.CreateElement("version");
                userNodeVersion.InnerText = xMLitems.version;
                rootNode.AppendChild(userNodeVersion);

                XmlNode userNodeUrl = xmlDoc.CreateElement("url");
                userNodeUrl.InnerText = xMLitems.UpdateFilePath;
                rootNode.AppendChild(userNodeUrl);

                if (xMLitems.changelogurl != string.Empty)
                {
                    XmlNode userNodechangelog = xmlDoc.CreateElement("changelog");
                    userNodechangelog.InnerText = xMLitems.changelogurl;
                    rootNode.AppendChild(userNodechangelog);
                }

                if (xMLitems.AlgoritmType != AutoUpdateXMLitems.HashingAlgoTypes.None)
                {
                    XmlNode userNodeChecksum = xmlDoc.CreateElement("checksum");
                    XmlAttribute attribute = xmlDoc.CreateAttribute("algorithm");
                    attribute.Value = xMLitems.AlgoritmType.ToString();
                    userNodeChecksum.Attributes.Append(attribute);
                    userNodeChecksum.InnerText = xMLitems.checksum;
                    rootNode.AppendChild(userNodeChecksum);
                }

                //update type
                switch (xMLitems.MandatoryType)
                {
                    case AutoUpdateXMLitems.MandatoryTypes.Not_Mandatory:

                        XmlNode not_mandatory = xmlDoc.CreateElement("mandatory");
                        not_mandatory.InnerText = "false";
                        rootNode.AppendChild(not_mandatory);
                        break;

                    case AutoUpdateXMLitems.MandatoryTypes.Mandatory:

                        XmlNode mandatory = xmlDoc.CreateElement("mandatory");
                        mandatory.InnerText = "true";
                        rootNode.AppendChild(mandatory);
                        break;

                    case AutoUpdateXMLitems.MandatoryTypes.MandatoryOption1:

                        XmlNode mandatory1 = xmlDoc.CreateElement("mandatory");
                        XmlAttribute attribute = xmlDoc.CreateAttribute("mode");
                        attribute.Value = "1";
                        mandatory1.Attributes.Append(attribute);
                        mandatory1.InnerText = "true";
                        rootNode.AppendChild(mandatory1);
                        break;

                    case AutoUpdateXMLitems.MandatoryTypes.MandatoryOption2:

                        XmlNode mandatory2 = xmlDoc.CreateElement("mandatory");
                        XmlAttribute attribute2 = xmlDoc.CreateAttribute("mode");
                        attribute2.Value = "2";
                        mandatory2.Attributes.Append(attribute2);
                        mandatory2.InnerText = "true";
                        rootNode.AppendChild(mandatory2);
                        break;

                    case AutoUpdateXMLitems.MandatoryTypes.MandatoryMinVersion:

                        XmlNode userNodeChecksumMV = xmlDoc.CreateElement("mandatory");
                        XmlAttribute attribute1 = xmlDoc.CreateAttribute("minversion");
                        attribute1.Value = xMLitems.minVersion;
                        userNodeChecksumMV.Attributes.Append(attribute1);
                        userNodeChecksumMV.InnerText = "true";
                        rootNode.AppendChild(userNodeChecksumMV);
                        break;

                    default:
                        break;
                }

                if (xMLitems.CommandLineArgs != string.Empty)
                {
                    XmlNode args = xmlDoc.CreateElement("args");
                    args.InnerText = xMLitems.CommandLineArgs;
                    rootNode.AppendChild(args);
                }

                pnl6A.Enabled = true;
                xmlDoc.Save(xMLitems.xmlFolderPath + xMLitems.xmlFileName);
                //Process.Start(xMLitems.xmlFolderPath + xMLitems.xmlFileName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGetVersion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;

            ofd.ShowDialog();

            if (ofd.FileName != string.Empty)
            {
                txtNewVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
        }
    }
}
