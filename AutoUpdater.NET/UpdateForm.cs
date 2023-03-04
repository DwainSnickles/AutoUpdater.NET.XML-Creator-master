﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AutoUpdaterDotNET
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UpdateForm : Form
    {
        private System.Timers.Timer _timer;
        private UpdateInfoEventArgs updateInfoEventArgs;
        private UpdateInfoEventArgs args;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="remindLater"></param>
        public UpdateForm(bool remindLater = false)
        {
            if (!remindLater)
            {
                InitializeComponent();
                var resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
                Text = AutoUpdater.DialogTitle;
                labelUpdate.Text = string.Format(resources.GetString("labelUpdate.Text", CultureInfo.CurrentCulture), AutoUpdater.AppTitle);
                labelDescription.Text =
                    string.Format(resources.GetString("labelDescription.Text", CultureInfo.CurrentCulture),
                        AutoUpdater.AppTitle, AutoUpdater.CurrentVersion, AutoUpdater.InstalledVersion);
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="args"></param>
        public void ShowUpdateForm(UpdateInfoEventArgs args)
        {

            InitializeComponent();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            Text = AutoUpdater.DialogTitle;
            labelUpdate.Text = string.Format(resources.GetString("labelUpdate.Text", CultureInfo.CurrentCulture), AutoUpdater.AppTitle);
            labelDescription.Text =
                string.Format(resources.GetString("labelDescription.Text", CultureInfo.CurrentCulture),
                    AutoUpdater.AppTitle, AutoUpdater.CurrentVersion, AutoUpdater.InstalledVersion);

        }

        /// <summary>
        /// 
        /// </summary>
        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void UpdateFormLoad(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.AllowNavigation = true;
            //webBrowser.Refresh(WebBrowserRefreshOption.Completely);
            //webBrowser.Navigate(AutoUpdater.ChangeLogURL);
            //webBrowser.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser.Navigate(AutoUpdater.ChangeLogURL + "?refresh= & Guid.NewGuid().ToString()");


        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (AutoUpdater.OpenDownloadPage)
            {
                var processStartInfo = new ProcessStartInfo(AutoUpdater.DownloadURL);

                Process.Start(processStartInfo);
            }
            else
            {
                AutoUpdater.DownloadUpdate();
            }
        }

        private void ButtonSkipClick(object sender, EventArgs e)
        {
            RegistryKey updateKey = Registry.CurrentUser.CreateSubKey(AutoUpdater.RegistryLocation);
            if (updateKey != null)
            {
                updateKey.SetValue("version", AutoUpdater.CurrentVersion.ToString());
                updateKey.SetValue("skip", 1);
                updateKey.Close();
            }
        }

        private void ButtonRemindLaterClick(object sender, EventArgs e)
        {
            if(AutoUpdater.LetUserSelectRemindLater)
            {
                var remindLaterForm = new RemindLaterForm();

                var dialogResult = remindLaterForm.ShowDialog();

                if(dialogResult.Equals(DialogResult.OK))
                {
                    AutoUpdater.RemindLaterTimeSpan = remindLaterForm.RemindLaterFormat;
                    AutoUpdater.RemindLaterAt = remindLaterForm.RemindLaterAt;
                }
                else if(dialogResult.Equals(DialogResult.Abort))
                {
                    AutoUpdater.DownloadUpdate();
                    return;
                }
                else
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }

            RegistryKey updateKey = Registry.CurrentUser.CreateSubKey(AutoUpdater.RegistryLocation);
            if (updateKey != null)
            {
                updateKey.SetValue("version", AutoUpdater.CurrentVersion);
                updateKey.SetValue("skip", 0);
                DateTime remindLaterDateTime = DateTime.Now;
                switch (AutoUpdater.RemindLaterTimeSpan)
                {
                    case RemindLaterFormat.Days:
                        remindLaterDateTime = DateTime.Now + TimeSpan.FromDays(AutoUpdater.RemindLaterAt);
                        break;
                    case RemindLaterFormat.Hours:
                        remindLaterDateTime = DateTime.Now + TimeSpan.FromHours(AutoUpdater.RemindLaterAt);
                        break;
                    case RemindLaterFormat.Minutes:
                        remindLaterDateTime = DateTime.Now + TimeSpan.FromMinutes(AutoUpdater.RemindLaterAt);
                        break;

                }
                updateKey.SetValue("remindlater", remindLaterDateTime.ToString(CultureInfo.CreateSpecificCulture("en-US")));
                SetTimer(remindLaterDateTime);
                updateKey.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="remindLater"></param>
        public void SetTimer(DateTime remindLater)
        {
            TimeSpan timeSpan = remindLater - DateTime.Now;
            _timer = new System.Timers.Timer
                {
                    Interval = (int) timeSpan.TotalMilliseconds
                };
            _timer.Elapsed += TimerElapsed;
            _timer.Start();
        }

        private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer.Stop();
            AutoUpdater.Start();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser.Document.Body.Style = "zoom:150%";
        }
    }
}
