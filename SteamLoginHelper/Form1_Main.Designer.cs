namespace SteamGuardCodeGiver
{
    partial class Form1_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Main));
            this.button1 = new System.Windows.Forms.Button();
            this.label_LastCode = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItemreally = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.m7CurrentCodeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberLeftLabel = new System.Windows.Forms.Label();
            this.webBrowser_InfoPage = new System.Windows.Forms.WebBrowser();
            this.pictureBox_AdBanner1 = new System.Windows.Forms.PictureBox();
            this.m7CodesLeftLabel = new System.Windows.Forms.Label();
            this.pictureBox_AdBanner2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox_Accounts = new System.Windows.Forms.ListBox();
            this.button_switch_acc = new System.Windows.Forms.Button();
            this.button_MyWebsite = new System.Windows.Forms.Button();
            this.button_MyProfile = new System.Windows.Forms.Button();
            this.textBox_InfoArea = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label_UpdateText = new System.Windows.Forms.Label();
            this.linkLabel_Advertise = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdBanner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdBanner2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(750, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Extras Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Extras_Click);
            // 
            // label_LastCode
            // 
            this.label_LastCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.label_LastCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_LastCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_LastCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastCode.ForeColor = System.Drawing.Color.White;
            this.label_LastCode.Location = new System.Drawing.Point(148, 377);
            this.label_LastCode.Name = "label_LastCode";
            this.label_LastCode.Size = new System.Drawing.Size(100, 32);
            this.label_LastCode.TabIndex = 3;
            this.label_LastCode.Text = "-";
            this.label_LastCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label_LastCode, "Click here to copy last code!");
            this.label_LastCode.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Click to copy a code!";
            this.notifyIcon1.BalloonTipTitle = "Steam Login Helper!";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Steam Guard Code";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItemreally});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show program";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItemreally
            // 
            this.closeToolStripMenuItemreally.Name = "closeToolStripMenuItemreally";
            this.closeToolStripMenuItemreally.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItemreally.Text = "Exit Program";
            this.closeToolStripMenuItemreally.Click += new System.EventHandler(this.closeToolStripMenuItemreally_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Click here to Get a Code :3";
            this.toolTip1.SetToolTip(this.button4, "Click on this then you\'ll get a code that you can paste!");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_CopyCode_Click);
            // 
            // m7CurrentCodeLabel
            // 
            this.m7CurrentCodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.m7CurrentCodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m7CurrentCodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m7CurrentCodeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m7CurrentCodeLabel.ForeColor = System.Drawing.Color.White;
            this.m7CurrentCodeLabel.Location = new System.Drawing.Point(12, 376);
            this.m7CurrentCodeLabel.Name = "m7CurrentCodeLabel";
            this.m7CurrentCodeLabel.Size = new System.Drawing.Size(130, 33);
            this.m7CurrentCodeLabel.TabIndex = 3;
            this.m7CurrentCodeLabel.Text = "Last Code:";
            this.m7CurrentCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.m7CurrentCodeLabel, "Click here to copy last code!");
            this.m7CurrentCodeLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(749, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Account Switcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "Click here to copy last code!");
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(750, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "My Steam Accounts";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label5, "Click here to copy last code!");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Info area";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label4, "Click here to copy last code!");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(46, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Code Giver";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label3, "Click here to copy last code!");
            // 
            // numberLeftLabel
            // 
            this.numberLeftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.numberLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLeftLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberLeftLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLeftLabel.ForeColor = System.Drawing.Color.White;
            this.numberLeftLabel.Location = new System.Drawing.Point(148, 418);
            this.numberLeftLabel.Name = "numberLeftLabel";
            this.numberLeftLabel.Size = new System.Drawing.Size(100, 33);
            this.numberLeftLabel.TabIndex = 5;
            this.numberLeftLabel.Text = "-";
            this.numberLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowser_InfoPage
            // 
            this.webBrowser_InfoPage.Location = new System.Drawing.Point(258, 107);
            this.webBrowser_InfoPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_InfoPage.Name = "webBrowser_InfoPage";
            this.webBrowser_InfoPage.Size = new System.Drawing.Size(480, 445);
            this.webBrowser_InfoPage.TabIndex = 8;
            this.webBrowser_InfoPage.Url = new System.Uri("https://sites.google.com/site/steamcodegiverxd/", System.UriKind.Absolute);
            this.webBrowser_InfoPage.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_InfoPage_DocumentCompleted);
            // 
            // pictureBox_AdBanner1
            // 
            this.pictureBox_AdBanner1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_AdBanner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_AdBanner1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_AdBanner1.ErrorImage = null;
            this.pictureBox_AdBanner1.InitialImage = null;
            this.pictureBox_AdBanner1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox_AdBanner1.Name = "pictureBox_AdBanner1";
            this.pictureBox_AdBanner1.Size = new System.Drawing.Size(735, 85);
            this.pictureBox_AdBanner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_AdBanner1.TabIndex = 9;
            this.pictureBox_AdBanner1.TabStop = false;
            this.pictureBox_AdBanner1.Click += new System.EventHandler(this.pictureBox_AdBanner1_Click);
            // 
            // m7CodesLeftLabel
            // 
            this.m7CodesLeftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.m7CodesLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m7CodesLeftLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m7CodesLeftLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m7CodesLeftLabel.ForeColor = System.Drawing.Color.White;
            this.m7CodesLeftLabel.Location = new System.Drawing.Point(12, 418);
            this.m7CodesLeftLabel.Name = "m7CodesLeftLabel";
            this.m7CodesLeftLabel.Size = new System.Drawing.Size(130, 33);
            this.m7CodesLeftLabel.TabIndex = 3;
            this.m7CodesLeftLabel.Text = "Codes Left:";
            this.m7CodesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m7CodesLeftLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // pictureBox_AdBanner2
            // 
            this.pictureBox_AdBanner2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_AdBanner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_AdBanner2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_AdBanner2.ErrorImage = null;
            this.pictureBox_AdBanner2.InitialImage = null;
            this.pictureBox_AdBanner2.Location = new System.Drawing.Point(8, 558);
            this.pictureBox_AdBanner2.Name = "pictureBox_AdBanner2";
            this.pictureBox_AdBanner2.Size = new System.Drawing.Size(735, 85);
            this.pictureBox_AdBanner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_AdBanner2.TabIndex = 10;
            this.pictureBox_AdBanner2.TabStop = false;
            this.pictureBox_AdBanner2.Click += new System.EventHandler(this.pictureBox_AdBanner2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(749, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 33);
            this.button5.TabIndex = 15;
            this.button5.Text = "Add Account";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(749, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 33);
            this.button6.TabIndex = 16;
            this.button6.Text = "Remove Account";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_RemoveAccount_Click);
            // 
            // listBox_Accounts
            // 
            this.listBox_Accounts.BackColor = System.Drawing.Color.Black;
            this.listBox_Accounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Accounts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Accounts.ForeColor = System.Drawing.Color.White;
            this.listBox_Accounts.FormattingEnabled = true;
            this.listBox_Accounts.ItemHeight = 18;
            this.listBox_Accounts.Location = new System.Drawing.Point(750, 81);
            this.listBox_Accounts.Name = "listBox_Accounts";
            this.listBox_Accounts.Size = new System.Drawing.Size(162, 128);
            this.listBox_Accounts.TabIndex = 17;
            this.listBox_Accounts.SelectedIndexChanged += new System.EventHandler(this.listBox_Accounts_SelectedIndexChanged);
            this.listBox_Accounts.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button_switch_acc
            // 
            this.button_switch_acc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button_switch_acc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_switch_acc.FlatAppearance.BorderSize = 2;
            this.button_switch_acc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_switch_acc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_switch_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_switch_acc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_switch_acc.ForeColor = System.Drawing.Color.White;
            this.button_switch_acc.Location = new System.Drawing.Point(749, 222);
            this.button_switch_acc.Name = "button_switch_acc";
            this.button_switch_acc.Size = new System.Drawing.Size(163, 33);
            this.button_switch_acc.TabIndex = 18;
            this.button_switch_acc.Text = "Switch to Account";
            this.button_switch_acc.UseVisualStyleBackColor = false;
            this.button_switch_acc.Click += new System.EventHandler(this.button_SwitchAccount_Click);
            // 
            // button_MyWebsite
            // 
            this.button_MyWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button_MyWebsite.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MyWebsite.FlatAppearance.BorderSize = 2;
            this.button_MyWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_MyWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_MyWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MyWebsite.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MyWebsite.ForeColor = System.Drawing.Color.White;
            this.button_MyWebsite.Location = new System.Drawing.Point(750, 610);
            this.button_MyWebsite.Name = "button_MyWebsite";
            this.button_MyWebsite.Size = new System.Drawing.Size(162, 33);
            this.button_MyWebsite.TabIndex = 24;
            this.button_MyWebsite.Text = "My Website";
            this.button_MyWebsite.UseVisualStyleBackColor = false;
            this.button_MyWebsite.Click += new System.EventHandler(this.button_MyWebsite_Click);
            // 
            // button_MyProfile
            // 
            this.button_MyProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button_MyProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MyProfile.FlatAppearance.BorderSize = 2;
            this.button_MyProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_MyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_MyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MyProfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MyProfile.ForeColor = System.Drawing.Color.White;
            this.button_MyProfile.Location = new System.Drawing.Point(750, 571);
            this.button_MyProfile.Name = "button_MyProfile";
            this.button_MyProfile.Size = new System.Drawing.Size(162, 33);
            this.button_MyProfile.TabIndex = 26;
            this.button_MyProfile.Text = "My Steam Profile";
            this.button_MyProfile.UseVisualStyleBackColor = false;
            this.button_MyProfile.Click += new System.EventHandler(this.button_MyProfile_Click);
            // 
            // textBox_InfoArea
            // 
            this.textBox_InfoArea.BackColor = System.Drawing.Color.Black;
            this.textBox_InfoArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_InfoArea.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InfoArea.ForeColor = System.Drawing.Color.White;
            this.textBox_InfoArea.Location = new System.Drawing.Point(12, 133);
            this.textBox_InfoArea.Name = "textBox_InfoArea";
            this.textBox_InfoArea.ReadOnly = true;
            this.textBox_InfoArea.Size = new System.Drawing.Size(236, 179);
            this.textBox_InfoArea.TabIndex = 30;
            this.textBox_InfoArea.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(750, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 33);
            this.button3.TabIndex = 32;
            this.button3.Text = "App\'s Page";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_AppPage_Click);
            // 
            // label_UpdateText
            // 
            this.label_UpdateText.BackColor = System.Drawing.Color.Transparent;
            this.label_UpdateText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_UpdateText.Enabled = false;
            this.label_UpdateText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdateText.ForeColor = System.Drawing.Color.White;
            this.label_UpdateText.Location = new System.Drawing.Point(750, 351);
            this.label_UpdateText.Name = "label_UpdateText";
            this.label_UpdateText.Size = new System.Drawing.Size(162, 137);
            this.label_UpdateText.TabIndex = 33;
            this.label_UpdateText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_UpdateText.Visible = false;
            this.label_UpdateText.Click += new System.EventHandler(this.label_updatetext_Click);
            // 
            // linkLabel_Advertise
            // 
            this.linkLabel_Advertise.AutoSize = true;
            this.linkLabel_Advertise.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Advertise.LinkColor = System.Drawing.Color.White;
            this.linkLabel_Advertise.Location = new System.Drawing.Point(9, 645);
            this.linkLabel_Advertise.Name = "linkLabel_Advertise";
            this.linkLabel_Advertise.Size = new System.Drawing.Size(295, 13);
            this.linkLabel_Advertise.TabIndex = 34;
            this.linkLabel_Advertise.TabStop = true;
            this.linkLabel_Advertise.Text = "Email maddada.web@gmail.com for details about advertising!";
            this.linkLabel_Advertise.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Advertise_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(358, 645);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(358, 13);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Please do me a favor and subscribe to my youtube channel, much love :D!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackgroundImage = global::SteamGuardCodeGiver.Properties.Resources.red_pattern_2_wallpaper_1920x1200__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel_Advertise);
            this.Controls.Add(this.label_UpdateText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_InfoArea);
            this.Controls.Add(this.listBox_Accounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_MyProfile);
            this.Controls.Add(this.button_MyWebsite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_switch_acc);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_AdBanner2);
            this.Controls.Add(this.pictureBox_AdBanner1);
            this.Controls.Add(this.webBrowser_InfoPage);
            this.Controls.Add(this.numberLeftLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.m7CurrentCodeLabel);
            this.Controls.Add(this.m7CodesLeftLabel);
            this.Controls.Add(this.label_LastCode);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdBanner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdBanner2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_LastCode;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Label numberLeftLabel;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItemreally;
        private System.Windows.Forms.WebBrowser webBrowser_InfoPage;
        private System.Windows.Forms.PictureBox pictureBox_AdBanner1;
        private System.Windows.Forms.Label m7CodesLeftLabel;
        private System.Windows.Forms.Label m7CurrentCodeLabel;
        private System.Windows.Forms.PictureBox pictureBox_AdBanner2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox_Accounts;
        private System.Windows.Forms.Button button_switch_acc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_MyWebsite;
        private System.Windows.Forms.Button button_MyProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBox_InfoArea;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_UpdateText;
        private System.Windows.Forms.LinkLabel linkLabel_Advertise;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

