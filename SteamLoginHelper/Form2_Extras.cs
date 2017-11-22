using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGuardCodeGiver
{
    public partial class Form2_Extras : Form
    {
        public Form2_Extras()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://store.steampowered.com/twofactor/manage_action");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:/Program Files/SteamLoginHelper/sc.txt");
            Application.Restart();
            Debug.WriteLine("xd12312321321");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            File.Delete(@"C:/Program Files/SteamLoginHelper/settings.txt");
            //File.WriteAllText("",path);  
            Application.Restart();
            Debug.WriteLine("xd12312321321");
        }
    }
}
