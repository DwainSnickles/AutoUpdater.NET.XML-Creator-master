﻿using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace AutoUpdaterTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //uncomment below line to see russian version
            
            //AutoUpdater.CurrentCulture = CultureInfo.CreateSpecificCulture("ru");

            //If you want to open download page when user click on download button uncomment below line.
 
            //AutoUpdater.OpenDownloadPage = true;

            //Don't want user to select remind later time in AutoUpdater notification window then uncomment 3 lines below so default remind later time will be set to 2 days.

            //AutoUpdater.LetUserSelectRemindLater = false;
            //AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Days;
            //AutoUpdater.RemindLaterAt = 2;

            //Want to handle update logic yourself then uncomment below line.

            //AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;

            //AutoUpdater.Start("http://rbsoft.org/updates/right-click-enhancer.xml");
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    var dialogResult =
                        MessageBox.Show(
                            string.Format(
                                "There is new version {0} avilable. You are using version {1}. Do you want to update the application now?",
                                args.CurrentVersion, args.InstalledVersion), @"Update Available",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            //You can use Download Update dialog used by AutoUpdater.NET to download the update.
                            
                            AutoUpdater.DownloadUpdate();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"There is no update avilable please try again later.", @"No update available",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                       @"There is a problem reaching update server please check your internet connection and try again later.",
                       @"Update check failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCheckForUpdate_Click(object sender, EventArgs e)
        {
            //UpdateInfoEventArgs args = new UpdateInfoEventArgs();
            //args.ChangelogURL = "http://sourcecodedepot.com/update/releases/index.html";
            //args.CurrentVersion = new Version("1.0.0.0");
            //args.InstalledVersion = Assembly.GetEntryAssembly().GetName().Version;
            //AutoUpdaterDotNET.UpdateForm updateForm = new UpdateForm(args, " Youtube Downloader Platinum ");
            //updateForm.ShowDialog();
            //UpdateInfoEventArgs args = new UpdateInfoEventArgs();
            //args.ChangelogURL = "http://sourcecodedepot.com/update/releases/index.html";
            //args.CurrentVersion = new Version("2.0");
            //args.InstalledVersion = Assembly.GetEntryAssembly().GetName().Version;

            AutoUpdater.Start("http://sourcecodedepot.com/update/ytd.xml");

            ///args.DownloadURL = "http://sourcecodedepot.com/update/UpdateTester.zip";
            ///
            //AutoUpdaterOnCheckForUpdateEvent(args);
            //var dialogResult =
            //           MessageBox.Show(
            //               string.Format(
            //                   "There is new version {0} avilable. You are using version {1}. Do you want to update the application now?",
            //                   args.CurrentVersion, args.InstalledVersion), @"Update Available",
            //               MessageBoxButtons.YesNo,
            //               MessageBoxIcon.Information);
            //AutoUpdater.CheckForUpdateEvent checkForUpdate = false;
            //AutoUpdater.Start(args);
            //UpdateInfoEventArgs eventArgs;
            //UpdateInfoEventArgs.eventArgs.IsUpdateAvailable
            //AutoUpdaterOnCheckForUpdateEvent(eventArgs.IsUpdateAvailable)
        }

       
    }
}
