using SteamGuardCodeGiver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGuardCodeGiver
{
    public partial class Form3_AddAccount : Form
    {
        public Form3_AddAccount()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_Username;
            this.AcceptButton = button_AddAccount;
        }

        private void button_AddAccount_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "" || textBox_Password.Text == "")
            {
                return;
            }

            Thread.Sleep(500);

            if (System.Windows.Forms.Application.OpenForms["Form1_Main"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1_Main"] as Form1_Main).AddAccount(textBox_Username.Text.Trim(), textBox_Password.Text);
            }

            Close();
        }
    }
}
