using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml.Serialization;
using System.Xml;
using System.Collections.ObjectModel;

namespace SteamGuardCodeGiver
{
    /**
     * 
     * Steam Login Helper, An app by Mohamad "maddada" Yahia :)
     * 
     * There was 2 main objectives to this app:
     * 
     * 1- Allow users login to their steam account without having to write a code from their phone each time!
     * 
     * 2- Allow users to switch between steam accounts very easily, While storing the login
     * details in a secure manner.
     * 
     **/

    public partial class Form1_Main : Form
    {
        public double appVersion = 1.0;
        static string currentCode;
        static int currentIndex;

        static PbinRecord mainPbinRecord;
        static AccountsRecord mainAccountsRecord;
        static Codes mainCodesRecord;

        private BackgroundWorker bwIMAGE;
        private BackgroundWorker bwIMAGE2;
        private BackgroundWorker bwPasteBin;
        private BackgroundWorker bwSwitchAccount;

        //==================================================================================================================================================
        // Constructor:
        //==================================================================================================================================================

        public Form1_Main()
        {
            InitializeComponent();

            this.Shown += this.Form1_Main_Shown;
            this.FormClosing += this.Form_Main_FormClosing;
            this.Activated += this.Form_Main_Activated;
        }

        //==================================================================================================================================================
        // OnLoad, Shown, Load:
        //==================================================================================================================================================

        //FINALLY CAN DO STUFF ON FORMLOAD!! THIS WORKS! 
        //Form1_Load wasn't working here for some reasona although it works in mmpicker! tried everything f this.
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            // do stuff after Load-event was raised            
        }

        //there’s also Form1_Shown which fires after the form is displayed.
        private void Form1_Main_Shown(Object sender, EventArgs e)
        {
            if (!BrowserEmulation.IsBrowserEmulationSet())
            {
                BrowserEmulation.SetBrowserEmulationVersion();
            }

            bwIMAGE = new BackgroundWorker();
            bwIMAGE.DoWork += new DoWorkEventHandler(bwIMAGE_DoWork);
            bwIMAGE.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bwIMAGE_RunWorkerCompleted);

            bwIMAGE2 = new BackgroundWorker();
            bwIMAGE2.DoWork += new DoWorkEventHandler(bwIMAGE2_DoWork);
            bwIMAGE2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bwIMAGE2_RunWorkerCompleted);

            bwPasteBin = new BackgroundWorker();
            bwPasteBin.DoWork += new DoWorkEventHandler(bwPasteBin_DoWork);
            bwPasteBin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bwPasteBin_RunWorkerCompleted);

            bwSwitchAccount = new BackgroundWorker();
            bwSwitchAccount.DoWork += new DoWorkEventHandler(bwSwitchAccount_DoWork);
            bwSwitchAccount.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bwSwitchAccount_RunWorkerCompleted);

            if (!bwPasteBin.IsBusy) bwPasteBin.RunWorkerAsync();

            if (mainAccountsRecord == null)
            {
                mainAccountsRecord = new AccountsRecord();
            }

            if (mainPbinRecord == null)
            {
                mainPbinRecord = new PbinRecord();
            }

            if (mainCodesRecord == null)
            {
                mainCodesRecord = new Codes();
            }

            Text = "maddada's Steam Login Helper v" + appVersion; if (appVersion == 1) Text += ".0";
            textBox_InfoArea.Text = "Hello :D!\n\nPress the \"Get a Code\" button to start!";

            CreateFiles();
        }

        private void Form1_Main_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }
        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }

        //Create Files Region:
        void CreateFiles()
        {
            try
            {
                if (!System.IO.Directory.Exists("C:/Program Files/SteamLoginHelper")) System.IO.Directory.CreateDirectory("C:/Program Files/SteamLoginHelper");
                if (!System.IO.Directory.Exists("C:/Program Files/SteamLoginHelper/resources")) System.IO.Directory.CreateDirectory("C:/Program Files/SteamLoginHelper/resources");


                string path = @"C:/Program Files/SteamLoginHelper/sc.txt";

                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                }


                path = @"C:/Program Files/SteamLoginHelper/settings.txt";

                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                };

                LoadSavedAccounts();
                LoadCodes();
            }

            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }

        }

        public void LoadCodes()
        {
            string path = @"C:/Program Files/SteamLoginHelper/sc.txt";
            try
            {
                if (new FileInfo(path).Length == 0)
                {
                    string temp1 = XmlHelper.ToXml(mainAccountsRecord);
                    temp1 = temp1.cc();
                    File.WriteAllText(path, temp1);
                    return;
                }

                else
                {
                    string txtContents1 = System.IO.File.ReadAllText(path);

                    txtContents1 = c.dd(txtContents1);

                    mainCodesRecord = XmlHelper.FromXml<Codes>(txtContents1);
                }

                if (mainCodesRecord.lastCode != null && mainCodesRecord.lastCode != "")
                {
                    currentCode = mainCodesRecord.lastCode;
                    label_LastCode.Text = mainCodesRecord.lastCode;
                }
                if (mainCodesRecord.count == 0)
                {
                    numberLeftLabel.Text = "-";
                }
                else
                {
                    numberLeftLabel.Text = "" + mainCodesRecord.count;
                }

                //Debug.WriteLine("txtContents1 = \n" + txtContents1 + "\n END OF txtContents1");
            }

            catch (Exception e)
            {
                PrintDebugInfo(e);
                Debug.Print("\n");
            }
        }

        // Fix Codes Region:
        #region Fix Codes:

        public void AfterAddingCodes()
        {
            fixCodes();

            this.BringToFront();
            this.Activate();
        }

        public void fixCodes()
        {
            try
            {
                mainCodesRecord.CodesList.Clear();
                mainCodesRecord.count = 30;
                string path = @"C:/Program Files/SteamLoginHelper/temp.txt";
                string path2 = @"C:/Program Files/SteamLoginHelper/sc.txt";

                //if (new FileInfo(path).Length == 0)
                //    return;

                string txt1 = System.IO.File.ReadAllText(path);
                //txt1 = c.dd(txt1);
                //txt1 = Regex.Replace(txt1, @"[\u000A\u000B\u000C\u000D\u2028\u2029\u0085]+", " ");
                Debug.WriteLine("txt1 = " + txt1);

                List<string> txtContents2 = new List<string>(txt1.Split(' '));

                //if (!txtContents2.FirstOrDefault().StartsWith("1.")) return;

                foreach (string s in txtContents2)
                {
                    if (s.Length == 7)
                    {
                        mainCodesRecord.CodesList.Add(s);
                    }
                    else if (s.Length == 9)
                    {
                        mainCodesRecord.CodesList.Add(s.Remove(7, 2));
                    }
                    else if (s.Length == 10)
                    {
                        mainCodesRecord.CodesList.Add(s.Remove(7, 3));
                    }
                    else if (s.Length == 11)
                    {
                        mainCodesRecord.CodesList.Add(s.Remove(7, 4));
                    }
                    else if (s.Length == 12)
                    {
                        mainCodesRecord.CodesList.Add(s.Remove(7, 5));
                    }
                }

                //write mainCodesRecord to disk
                string temp2 = XmlHelper.ToXml(mainCodesRecord);
                System.IO.File.WriteAllText(path2, temp2.cc());


                textBox_InfoArea.Text = "Congrats!\nYou added 30 new Codes!" + "\n\n";
                numberLeftLabel.Text = "30";
                label_LastCode.Text = "-";
                try { File.Delete(path); } catch { }


            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
                Debug.Print("\n");
            }
        }


        #endregion
        // Code Region:
        #region Code Region

        void CopyCodeToClipboard()
        {
            string path = @"C:/Program Files/SteamLoginHelper/sc.txt";

            try
            {
                int temp = mainCodesRecord.count - 1;

                if (mainCodesRecord.count > 1)
                {
                    //Set Current Code to the last element in the List
                    currentCode = mainCodesRecord.CodesList.Last();
                    //Remove the last element
                    mainCodesRecord.CodesList.RemoveAt(mainCodesRecord.CodesList.Count - 1);

                    System.Windows.Forms.Clipboard.SetText(currentCode);

                    //notifyIcon1.BalloonTipText = "You Copied a Code! [ " + currentCode + " ]";
                    //notifyIcon1.ShowBalloonTip(1);

                    if (textBox_InfoArea.Text.StartsWith("Hello")) textBox_InfoArea.Clear();
                    textBox_InfoArea.Text = "Code Copied!\n[" + currentCode + "]" + "\nCodes Left: " + temp + "\n\n" + textBox_InfoArea.Text;
                }

                else if (mainCodesRecord.count == 1)
                {
                    //Set Current Code to the last element in the List
                    currentCode = mainCodesRecord.CodesList.Last();
                    //notifyIcon1.BalloonTipText = "You need to add Codes :(\n Follow The Instructions to add more!";
                    //notifyIcon1.ShowBalloonTip(1);
                    openAddCodesForm();

                    System.Windows.Forms.Clipboard.SetText(currentCode);

                    textBox_InfoArea.Text = "Last Code Left! \n[" + currentCode + "]" + "\n\nUse this code and follow the instructions to get more!" + "\n\n\n";
                    //Don't remove the last element
                    //Open the txt file and steam site so that the user can get more codes
                    //with the current code that he has.
                }

                else if (mainCodesRecord.count == 0 && currentCode != "")
                {
                    //Set Current Code to the last element in the List
                    currentCode = mainCodesRecord.CodesList.Last();
                    //notifyIcon1.BalloonTipText = "You need to add Codes :(\n Follow The Instructions to add more!";
                    //notifyIcon1.ShowBalloonTip(1);
                    openAddCodesForm();

                    System.Windows.Forms.Clipboard.SetText(currentCode);

                    textBox_InfoArea.Text = "Last Code Left! \n[" + currentCode + "]" + "\n\nUse this code and follow the instructions to get more!" + "\n\n\n";
                    //Don't remove the last element
                    //Open the txt file and steam site so that the user can get more codes
                    //with the current code that he has.
                }

                else if (mainCodesRecord.count == 0 && currentCode == "")
                {
                    //Open the txt file and steam site so that the user can get more codes
                    //with the current code that he has.
                    openAddCodesForm();
                    //currentCode = "-";
                    textBox_InfoArea.Text = "Hey!\n\nPlease follow the instructions to add codes :D\n\nYou might need to get a code from your phone for this time, but you won't need to do that in the next times.";
                    //notifyIcon1.BalloonTipText = "No more codes left :(\n open the program and add more!";
                    //notifyIcon1.ShowBalloonTip(1);
                }

                //set main codes record :D
                mainCodesRecord.lastCode = currentCode;
                if (temp == -1)
                {
                    mainCodesRecord.count = temp + 1;
                }
                else
                {
                    mainCodesRecord.count = temp;
                }

                //write mainCodesRecord to disk
                string temp2 = XmlHelper.ToXml(mainCodesRecord);
                System.IO.File.WriteAllText(path, temp2.cc());

                //set labels
                label_LastCode.Text = currentCode;

                if (temp != -1)
                    numberLeftLabel.Text = "" + temp;
                else
                    numberLeftLabel.Text = "-";
            }
            catch (Exception e) { PrintDebugInfo(e); }
        }

        Form4_AddNewCodes FourthForm;
        void openAddCodesForm()
        {
            notifyIcon1.BalloonTipText = "No Codes Left :(\nFollow The Instructions!";
            notifyIcon1.ShowBalloonTip(2);

            this.ShowInTaskbar = true;
            notifyIcon1.Visible = true;

            if ((FourthForm == null) || (FourthForm.IsDisposed))
            {
                FourthForm = new Form4_AddNewCodes(); //the Add Codes Form
                FourthForm.Show();
            }
        }

        #endregion


        // Form Methods Region        
        #region Form Methods

        private Form2_Extras SecondForm;
        private void button_Extras_Click(object sender, EventArgs e)
        {
            if ((SecondForm == null) || (SecondForm.IsDisposed))
            {
                SecondForm = new Form2_Extras();
                SecondForm.Show();

            }
            SecondForm.Show();
        }

        private void button_AppPage_Click(object sender, EventArgs e)
        {
            Process.Start("http://codegiver.maddada.com");
        }

        private void button_CopyCode_Click(object sender, EventArgs e)
        {
            CopyCodeToClipboard();
        }

        //My Steam Account Button
        private void button_MyProfile_Click(object sender, EventArgs e)
        {
            Process.Start("http://bit.ly/m7steam");
        }

        //My Website Button
        private void button_MyWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("http://bit.ly/m7site");
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
            if (!label_LastCode.Text.Contains("-"))
            {
                System.Windows.Forms.Clipboard.SetText(label_LastCode.Text);
                //notifyIcon1.BalloonTipText = "Code Copied: " + currentCode + "\n" + codesLeft + " codes left.";
                //notifyIcon1.ShowBalloonTip(1);
                textBox_InfoArea.Text = "Last Code Recopied!" +
                    "\n [ " + label_LastCode.Text + " ]" + "\n\n" + textBox_InfoArea.Text;
            }
        }

        private void label_updatetext_Click(object sender, EventArgs e)
        {
            //Process.Start("http://codegiver.maddada.com");
        }

        private void linkLabel_Advertise_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:maddada.web@gmail.com?Subject=Regarding%20Advertising%20on%20Steam%20Code%20Giver");
        }

        int once1 = 0;
        private void webBrowser_InfoPage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (once1 == 0)
            {
                //webBrowser1.Focus();
                //SendKeys.Send("^-"); // [CTRL]+[-] zoomout
                once1 = 1;
            }
        }

        private void pictureBox_AdBanner1_Click(object sender, EventArgs e)
        {
            Process.Start(mainPbinRecord.pbin_ImageLink1);
            textBox_InfoArea.Text = "Thanks for checking out our Sponsors!";
        }

        private void pictureBox_AdBanner2_Click(object sender, EventArgs e)
        {
            Process.Start(mainPbinRecord.pbin_ImageLink2);
            textBox_InfoArea.Text = "Thanks for checking out our Sponsors!";
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SwitchAccount(listBox_Accounts.SelectedIndex);
            listBox_Accounts.ClearSelected();
        }

        #endregion


        // Account Switcher Region        
        #region Account Switcher Region

        //commands i need to run to switch: 
        //taskkill /F /IM csgo.exe
        //taskkill /F /IM GameOverlayUI.exe
        //taskkill /F /IM Steam.exe
        //timeout /t 2
        //start "" "C:\Program Files (x86)\Steam\Steam.exe" -login fadel26 iloveahmedothman


        public void LoadSavedAccounts()
        {
            try
            {

                string filePath = @"C:/Program Files/SteamLoginHelper/settings.txt";
                listBox_Accounts.DisplayMember = "x1";
                mainAccountsRecord = new AccountsRecord();

                string temp = File.ReadAllText(filePath);
                if (temp == "") return;
                string temp2 = c.dd(temp);

                if (temp2 != null)
                {
                    mainAccountsRecord = XmlHelper.FromXml<AccountsRecord>(temp2);

                    listBox_Accounts.DataSource = mainAccountsRecord.myAccountsList;

                    if (mainAccountsRecord.myAccountsList.Count == 0)
                    {
                        label5.Text = "Add your Accounts!";
                    }
                }
                else
                {
                    label5.Text = "Add your Accounts!";
                }


                listBox_Accounts.ClearSelected();
            }
            catch (Exception e)
            {
                PrintDebugInfo(e);
            }
        }

        private void button_SwitchAccount_Click(object sender, EventArgs e)
        {
            //add code to switch to the selected account in listBox1
            SwitchAccount(listBox_Accounts.SelectedIndex);
        }

        private void button_RemoveAccount_Click(object sender, EventArgs e)
        {
            RemoveAccount(listBox_Accounts.SelectedIndex);
        }

        //Remove account
        private void RemoveAccount(int accIndex)
        {
            try
            {
                string filePath = @"C:/Program Files/SteamLoginHelper/settings.txt";

                if (listBox_Accounts.SelectedIndex == -1)
                    return;

                if (Convert.ToString(listBox_Accounts.SelectedValue).StartsWith("Add"))
                    return;

                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Removing Account", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    mainAccountsRecord.myAccountsList.RemoveAt(accIndex);
                    mainAccountsRecord.numberOfAccounts--;

                    string temp = XmlHelper.ToXml(mainAccountsRecord);
                    File.WriteAllText(filePath, c.cc(temp));

                    listBox_Accounts.ClearSelected();

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }
        }

        //public void RemoveAllAccounts()
        //{
        //    try
        //    {
        //        string filePath = @"C:/Program Files/SteamLoginHelper/settings.xml";

        //        int max = mainAccountsRecord.numberOfAccounts;

        //        for (int i = 0; i < max; i++)
        //        {
        //            mainAccountsRecord.myAccountsList.RemoveAt(0);
        //            mainAccountsRecord.numberOfAccounts--;
        //        }

        //        string temp = XmlHelper.ToXml(mainAccountsRecord);
        //        File.WriteAllText(filePath, c.cc(temp));
        //    }
        //    catch (Exception e)
        //    {
        //        PrintDebugInfo(e);
        //    }
        //}

        public void AddAccount(string username, string password)
        {
            string filePath = @"C:/Program Files/SteamLoginHelper/settings.txt";

            Account tempacc = new Account();
            tempacc.x1 = username;
            tempacc.x2 = c.cc(password);

            mainAccountsRecord.myAccountsList.Add(tempacc);

            mainAccountsRecord.numberOfAccounts++;

            listBox_Accounts.DataSource = mainAccountsRecord.myAccountsList;

            listBox_Accounts.ClearSelected();

            string temp = XmlHelper.ToXml(mainAccountsRecord);
            File.WriteAllText(filePath, c.cc(temp));

            label5.Text = "My Steam Accounts";

            this.BringToFront();
            this.Activate();
        }

        string steamdir = "start \"\" \"C:/Program Files (x86)/Steam/Steam.exe\"";

        public void SwitchAccount(int accIndex)
        {
            try
            {
                currentIndex = accIndex;

                if (currentIndex == -1)
                    return;


                if (mainAccountsRecord.myAccountsList[currentIndex].x1 == "")
                    return;


                if (!bwSwitchAccount.IsBusy) bwSwitchAccount.RunWorkerAsync();

                if (textBox_InfoArea.Text.StartsWith("Hello"))
                    textBox_InfoArea.Clear();

                textBox_InfoArea.Text = "Switching to [ " + mainAccountsRecord.myAccountsList[currentIndex].x1 + " ]" + "\n\n";

                notifyIcon1.BalloonTipText = "Switching to [ " + mainAccountsRecord.myAccountsList[currentIndex].x1 + " ]";
                notifyIcon1.ShowBalloonTip(1);
            }
            catch (Exception e)
            {
                PrintDebugInfo(e);
            }

        }

        //Starting the "Add Account Form"
        private Form3_AddAccount ThirdForm;
        private void button5_Click(object sender, EventArgs e)
        {
            if ((ThirdForm == null) || (ThirdForm.IsDisposed))

            {
                ThirdForm = new Form3_AddAccount(); //the createaccount form
                ThirdForm.Show();
            }

            ThirdForm.Show();
        }


        public static void ExecuteCommand(string command)
        {
            string windirectory = Environment.GetEnvironmentVariable("windir");
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo((windirectory + "\\System32\\cmd.exe"), "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);
            process.WaitForExit();
            exitCode = process.ExitCode;
            process.Close();
        }


        //==================================================================================================================================================
        // Resize, notifyIcon1, Toolstrip Methods:
        //==================================================================================================================================================


        //handling resize
        /*protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
                this.Show();
            }

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.Hide();
            }
        }*/

        private void Form_Main_Activated(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

            //single click on notifyicon
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Activate();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //double click on notifyIcon
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {

            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Making X button minimize to tray area!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //notifyIcon1.Visible = true;
                //this.Hide();
                //e.Cancel = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clicking on "Show Program"
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }


        private void closeToolStripMenuItemreally_Click(object sender, EventArgs e)
        {
            //closing when notifyicon menu "Exit Program" is clicked:
            Application.Exit();
        }

        //==================================================================================================================================================
        // Pastebin Region:
        //==================================================================================================================================================

        #region Getting and setting Stuff From Pastebin Region :D



        string _pastebinstring = string.Empty;
        // format like this:
        //0-> use it for testing if it loaded anything
        //1-> first banner links to (bit.ly)
        //2-> first banner image (imgur)
        //3-> first banner no redownloading number (Version of image)
        //4-> 2nd banner links to (bit.ly)
        //5-> 2nd banner image (imgur)
        //6-> 2nd banner no redownloading number (Version of image)
        //7-> update checker latest version
        //8-> update checker update notes :>
        //9-> Sponsored by


        void getFromPastebin(string url)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            Stream stream;

            try
            {
                stream = client.OpenRead(url);
                StreamReader reader = new StreamReader(stream);
                _pastebinstring = reader.ReadToEnd();

                mainPbinRecord = XmlHelper.FromXml<PbinRecord>(_pastebinstring);
                Debug.WriteLine(mainPbinRecord);
            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }
        }

        #endregion



        //==================================================================================================================================================
        // Background Workers:
        //==================================================================================================================================================

        int once2 = 0;
        private void bwPasteBin_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (once2 == 0)
                {
                    Debug.WriteLine("insideonce=0");
                    getFromPastebin("https://pastebin.com/raw/ZQ2LRjpB"); //working
                    once2 = 1;
                }
            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }
        }

        private void bwPasteBin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                CheckUpdates();

                if (mainPbinRecord.pbin_ImageVersion1 != mainPbinRecord.pbin_ImageVersion2)
                    if (!bwIMAGE.IsBusy) bwIMAGE.RunWorkerAsync();

                if (!bwIMAGE2.IsBusy) bwIMAGE2.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }
        }

        private void bwIMAGE_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!System.IO.Directory.Exists("C:/Program Files/SteamLoginHelper/resources/"))
                    System.IO.Directory.CreateDirectory("C:/program files/SteamLoginHelper/resources");

                if (mainPbinRecord.pbin_ImageImgur1 != null)
                {
                    if (!File.Exists("C:/Program Files/SteamLoginHelper/resources/" + mainPbinRecord.pbin_ImageVersion2 + ".gif"))
                    {
                        DownloadRemoteImageFile(mainPbinRecord.pbin_ImageImgur1, "C:/Program Files/SteamLoginHelper/resources/" + mainPbinRecord.pbin_ImageVersion1 + ".gif");
                    }
                }

            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }
        }

        private void bwIMAGE_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pictureBox_AdBanner1.ImageLocation = "C:/Program Files/SteamLoginHelper/resources/" + mainPbinRecord.pbin_ImageVersion1 + ".gif";
            }
            catch { textBox_InfoArea.Text = "Error: No Internet Connection"; }
        }

        private void bwIMAGE2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!System.IO.Directory.Exists("C:/Program Files/SteamLoginHelper/resources/")) System.IO.Directory.CreateDirectory("C:/program files/SteamLoginHelper/resources");


                if (mainPbinRecord.pbin_ImageImgur2 != null)
                {
                    if (!File.Exists("C:/Program Files/SteamLoginHelper/resources/" + mainPbinRecord.pbin_ImageVersion2 + ".gif"))
                    {
                        DownloadRemoteImageFile(mainPbinRecord.pbin_ImageImgur2, "C:/Program Files/SteamLoginHelper/resources/" + mainPbinRecord.pbin_ImageVersion2 + ".gif");
                    }
                }

            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }
        }

        private void bwIMAGE2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (mainPbinRecord.pbin_ImageImgur2 != null)
                {
                    pictureBox_AdBanner2.ImageLocation = "C:/Program Files/SteamLoginHelper/resources/" + mainPbinRecord.pbin_ImageVersion2 + ".gif";
                    if (mainPbinRecord.pbin_ImageVersion1 == mainPbinRecord.pbin_ImageVersion2)
                    {
                        pictureBox_AdBanner1.ImageLocation = "C:/Program Files/SteamLoginHelper/resources/" + mainPbinRecord.pbin_ImageVersion2 + ".gif";
                    }
                    Debug.WriteLine("inside bwimage2 complete");
                }
            }
            catch { textBox_InfoArea.Text = "Error: No Internet Connection"; }
        }

        private void bwSwitchAccount_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //taskkill /F /IM csgo.exe
                //taskkill /F /IM GameOverlayUI.exe
                //taskkill /F /IM Steam.exe
                //timeout /t 2

                ExecuteCommand("taskkill /F /IM csgo.exe");
                ExecuteCommand("taskkill /F /IM dota2.exe");
                ExecuteCommand("taskkill /F /IM pubg.exe");
                ExecuteCommand("taskkill /F /IM steam.exe");
                ExecuteCommand("taskkill /F /IM TslGame.exe");
                ExecuteCommand("taskkill /F /IM GameOverlayUI.exe");
                Thread.Sleep(1000);
                ExecuteCommand(steamdir + " -login " + mainAccountsRecord.myAccountsList[currentIndex].x1 + " " + c.dd(mainAccountsRecord.myAccountsList[currentIndex].x2));

            }
            catch (Exception ex)
            {
                PrintDebugInfo(ex);
            }
        }

        private void bwSwitchAccount_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

            }
            catch { }
        }

        #endregion


        // Update Checker Region        
        #region update check region


        public void CheckUpdates()
        {
            try
            {
                if (Convert.ToDouble(mainPbinRecord.pbin_version) > appVersion)
                {
                    label_UpdateText.Enabled = true;
                    label_UpdateText.Visible = true;
                    label_UpdateText.Text = "Notice: New Update is out! \nVersion " + mainPbinRecord.pbin_version + "\n\n" + "Changelog: " + mainPbinRecord.pbin_changelog + "\n\nGo to the App's Page to download it!";

                }
                else
                {
                    label_UpdateText.Enabled = true;
                    label_UpdateText.Visible = true;
                    label_UpdateText.Text = "You have the latest version!\n\n";
                }

                Text += "" + mainPbinRecord.pbin_sponsoredby;
            }
            catch { }
        }

        #endregion


        // My User-Defined Classes Region        
        #region My User-Defined Classes
        public class AccountsRecord
        {
            private AccountsRecord mainAccountsRecord;

            public BindingList<Account> myAccountsList { get; set; }
            public int numberOfAccounts { get; set; }

            public AccountsRecord()
            {
                this.myAccountsList = new BindingList<Account>();
                this.numberOfAccounts = 0;
            }

            public AccountsRecord(AccountsRecord mainAccountsRecord)
            {
                this.mainAccountsRecord = mainAccountsRecord;
            }
        }

        public class Account
        {
            public string x1 { get; set; }
            public string x2 { get; set; }
        }

        public class Codes
        {
            //public List<string> Codes { get; set; }
            public string lastCode { get; set; }
            public int count { get; set; }
            public List<string> CodesList { get; set; }
            public Codes()
            {
                this.CodesList = new List<string>();
                this.count = 0;
                this.lastCode = "";
            }
        }

        public class PbinRecord
        {
            public string pbin_teststext;
            public string pbin_ImageLink1;
            public string pbin_ImageImgur1;
            public string pbin_ImageVersion1;
            public string pbin_ImageLink2;
            public string pbin_ImageImgur2;
            public string pbin_ImageVersion2;
            public string pbin_version;
            public string pbin_changelog;
            public string pbin_sponsoredby;
        }
        #endregion


        // My Misc Methods Region        
        #region misc methods
        public void PrintDebugInfo(Exception e)
        {
            Debug.WriteLine("\n\n\n");
            Debug.WriteLine(e.ToString());
            Debug.WriteLine("\n\n\n");
        }

        private void listBox_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Convert.ToString(listBox_Accounts.SelectedValue) == "")
            //{
            //    listBox_Accounts.ClearSelected();
            //}
        }


        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://youtube.com/maddada");
        }
    }   /// Code gpes above this bracket :>
}
