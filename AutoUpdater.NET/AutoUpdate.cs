using AutoUpdaterDotNET.Wizard;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

// 3/1/2023 update AutoUpdater.net to be used from the toolbox addding all properties so end user can just type in event args directly
//Todo create XML file and allow the app and xml to server
namespace AutoUpdaterDotNET
{

    /// <summary>
    /// AutoUpdate Component Class
    /// </summary>
    [ToolboxBitmap(typeof(AutoUpdate), "AutoUpdate.png")]
    public partial class AutoUpdate : Component, INotifyPropertyChanged
    {
        private Boolean m_RunStartWizard; 

        /// <summary>
        /// Component class Initialize 
        /// </summary>
        public AutoUpdate()
        {
            InitializeComponent();
            OnPropertyChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// event to run when property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(object sender, EventArgs e)
        {
            //// run when control first added to users form
            if (Properties.Settings.Default.isFirstRun)
            {
                    frmWizard frm = new frmWizard();
                    frm.ShowDialog();
                    Properties.Settings.Default.isFirstRun = false;
                    Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Component Class Container
        /// </summary>
        /// <param name="container"></param>
        public AutoUpdate(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// Run the wizard on start up and user controlled if needed by changing the drop down to true
        /// </summary>
        /// 
        [Browsable(true)]
        public Boolean RunStartWizard
        {
            get { return m_RunStartWizard; }
            set
            {
                m_RunStartWizard = value;

                if (m_RunStartWizard)
                {
                    frmWizard frm = new frmWizard();
                    frm.ShowDialog();
                    Properties.Settings.Default.isFirstRun = false;
                    Properties.Settings.Default.Save();
                }

            } 
        }

        /// <summary>
        /// Sets the path to XML file to be used n website.
        /// eg - @C:\\Somedir
        /// </summary>
        public string XMLLocalPath { get; set; }

        /// <summary>
        /// Sets the path to Local XML file to be used n website.
        /// eg - https://pathtoserver/update.xml
        /// </summary>
        public string XMLPath { get; set; }

        /// <summary>
        /// Sets the path for change log on website
        /// </summary>
        public string ChangeLogURL { get; set; }

        /// <summary>
        /// Sets the version of the update must be formated like 0.0.0.0
        /// </summary>
        public string UpdateVersion { get; set; } = "0.0.0.0";

        /// <summary>
        /// Sets the installed version of the update must be formated like 0.0.0.0
        /// </summary>
        public string InstalledVersion { get; set; } = "0.0.0.0";
      
        /// <summary>
        /// runs the wizard form to update properties
        /// </summary>
        void RunWizard()
        {
            frmWizard fw = new frmWizard();
            fw.ShowDialog();
        }

    }
}

/// <summary>
/// Adds a combobox to propgrid with values
/// </summary>
internal class Combobox : StringConverter
{
    public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
    {
        return true;    // <----- just highlight! remember to write it lowecase
    }

    public override TypeConverter.StandardValuesCollection GetStandardValues(
        ITypeDescriptorContext context)
    {
        string[] a = { "0", "15", "30", "45", "60", "75", "90" };
        return new StandardValuesCollection(a);
    }

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
    {
        return true;
    }
}

/// <summary>
/// 
/// </summary>
public class PropertyChangedBase : INotifyPropertyChanged
{
    /// <summary>
    /// 
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyName"></param>
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
