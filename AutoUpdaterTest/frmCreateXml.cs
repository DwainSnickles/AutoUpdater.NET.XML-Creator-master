using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// Advance to next panel eg pnl1 - pnl6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Page == 8) { return; }

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

        /// <summary>
        /// Undocks all Panels, Displays and docks panels based on page number
        /// </summary>
        /// <param name="PanelNumber"></param>
        private void DisplayPanel(int PanelNumber)
        {

            if (Page == 8)
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
            this.pnl7.Dock = System.Windows.Forms.DockStyle.None;
            this.pnl8.Dock = System.Windows.Forms.DockStyle.None;

            String XMLFilePath = AppDomain.CurrentDomain.BaseDirectory + "XMLFile1.xml";

            switch (PanelNumber)
            {
                case 1:

                    this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Enter new version number, Click next to continue";
                    pnl1.BringToFront();
                    break;

                case 2:

                    this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Example https://rbsoft.org/downloads/AutoUpdaterTest.zip";
                    pnl2.BringToFront();
                    break;

                case 3:

                    this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Example https://github.com/AutoUpdater.NET/releases";
                    pnl3.BringToFront();
                    break;

                case 4:

                    this.pnl4.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Is this download mandatory?";
                    pnl4.BringToFront();
                    break;

                case 5: //mandatory minimum only used as option when madatory download is set to true

                    this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Does the mandatory download require a minimum version";
                    pnl5.BringToFront();
                    break;

                case 6: //Added Checksum
                   
                    this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Optional, Select Checksum type and enter Checksum value";
                    pnl6.BringToFront();
                    break;

                case 7: //Create xml 

                    this.pnl7.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Enter XML file name and click next to continue";
                    pnl7.BringToFront();
                    //WriteXML()
                    break;

                case 8: //Review XML
                    //Create xml file and display in web browser control
                    //once complete hide lblCreateXML
                    this.pnl8.Dock = System.Windows.Forms.DockStyle.Fill;
                    labelStatus.Text = "Review XML and Save to disk";
                    pnl8.BringToFront();
                    break;

                default:
                    break;
            }
        }

        private void frmCreateXml_Load(object sender, EventArgs e)
        {
            DisplayPanel(1);
        }

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

        private void btnCreateXMLFile_Click(object sender, EventArgs e)
        {
            if (txtXmlFilename.Text != string.Empty && txtSaveToFolder.Text != string.Empty)
            {
                createXML();
            }
            else { MessageBox.Show("Both answers are required. Please try again", "Can't Write XML"); }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSaveToFolder.Text = folderDlg.SelectedPath + @"\";
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btnOpenXMLFile_Click(object sender, EventArgs e)
        {
            Process.Start(@txtSaveToFolder.Text + txtXmlFilename.Text);
        }

        /// <summary>
        /// Create the xml file to be used for Autoupdate
        /// </summary>
        private void createXML()
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
            userNodeVersion.InnerText = txtNewVersion.Text;
            rootNode.AppendChild(userNodeVersion);

            XmlNode userNodeUrl = xmlDoc.CreateElement("url");
            userNodeUrl.InnerText = txtDownloadURL.Text;
            rootNode.AppendChild(userNodeUrl);

            XmlNode userNodechangelog = xmlDoc.CreateElement("changelog");
            userNodechangelog.InnerText = txtChangelogURL.Text;
            rootNode.AppendChild(userNodechangelog);
            
            if (cmbCheckSum.SelectedIndex > 0)
            {
                XmlNode userNodeChecksum = xmlDoc.CreateElement("checksum");
                XmlAttribute attribute = xmlDoc.CreateAttribute("algorithm");
                attribute.Value = cmbCheckSum.SelectedItem.ToString();
                userNodeChecksum.Attributes.Append(attribute);
                userNodeChecksum.InnerText = txtCheckSum.Text;
                rootNode.AppendChild(userNodeChecksum);
            }

            if (rbMandatoryFalse.Checked)
            {
                XmlNode userNodemandatory = xmlDoc.CreateElement("mandatory");
                userNodemandatory.InnerText = "false";
                rootNode.AppendChild(userNodemandatory);
            }

            if (rbMandatoryTrue.Checked)
            {
                switch (ckbCustomMinVersion.Checked)
                {
                    case false: //<mandatory mode="2">true</mandatory>
                        XmlNode userNodeChecksumTrue = xmlDoc.CreateElement("mandatory");
                        XmlAttribute attribute = xmlDoc.CreateAttribute("mode");
                        attribute.Value = "2";
                        userNodeChecksumTrue.Attributes.Append(attribute);
                        userNodeChecksumTrue.InnerText = "true";
                        rootNode.AppendChild(userNodeChecksumTrue);
                        break;

                    case true: //<mandatory minVersion="1.2.0.0">
                        XmlNode userNodeChecksumMV = xmlDoc.CreateElement("mandatory");
                        XmlAttribute attribute1 = xmlDoc.CreateAttribute("minversion");
                        attribute1.Value = txtMinimunVersion.Text.ToString().Trim();
                        userNodeChecksumMV.Attributes.Append(attribute1);
                        userNodeChecksumMV.InnerText = "true";
                        rootNode.AppendChild(userNodeChecksumMV);
                        break;

                    default:
                        break;
                }
            }

            xmlDoc.Save(txtSaveToFolder.Text + txtXmlFilename.Text);
            Process.Start(txtSaveToFolder.Text + txtXmlFilename.Text);
        }
        private void rbMandatoryTrue_CheckedChanged(object sender, EventArgs e)
        {
            pnl5.Enabled = true;
        }

        private void rbMandatoryFalse_CheckedChanged(object sender, EventArgs e)
        {
            pnl5.Enabled = true;
        }

        private void ckbCustomMinVersion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCustomMinVersion.Checked == false)
            {
                txtMinimunVersion.Text = string.Empty;
            }
        }

    }
}
