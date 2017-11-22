using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGuardCodeGiver
{
    public partial class Form4_AddNewCodes : Form
    {
        public Form4_AddNewCodes()
        {
            InitializeComponent();

            Shown += Form4_AddNewCodes_Shown;
        }

        private void Form4_AddNewCodes_Load_1(object sender, EventArgs e)
        {

        }

        private void Form4_AddNewCodes_Shown(object sender, EventArgs e)
        {
            label2_Transparent.Focus();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                //fixCodes();
                string temp = Regex.Replace(textBox2.Text, @"[\u000A\u000B\u000C\u000D\u2028\u2029\u0085]+", " ");
                if (!textBox2.Text.Contains("1.") || !textBox2.Text.Contains("30."))
                {
                    textBox2.Text = "Please paste the Codes Correctly!\r\nCopy from the start of the 1. to the end of the last code. \r\n(As shown in the image!)\r\nThen paste over this text!";
                    return;
                }

                string path = @"C:/Program Files/SteamLoginHelper/temp.txt";

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                }

                string textcontents = temp;

                System.IO.File.WriteAllText(path, textcontents);

                if (System.Windows.Forms.Application.OpenForms["Form1_Main"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1_Main"] as Form1_Main).AfterAddingCodes();
                }

                Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\n\n\n");
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("\n\n\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://store.steampowered.com/twofactor/manage_action");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
