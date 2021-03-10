using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Net;
using System.Media;
using System.Buffers;
using System.CodeDom;
using Microsoft.Win32;
using Accessibility;
using Microsoft.VisualBasic;
using Microsoft.CSharp;
using System.Configuration;

namespace Ultra_Ransomware
{
    public partial class UltraShow : Form
    {
        public UltraShow()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = true;
            ControlBox = false;
            ShowInTaskbar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("This file is classified as ransomware!, Other words you are attempting to run a ransomware! But if you have a VM (Virtual Machine) then go ahead click Yes to continue otherwise No", "Ultra_Ransomware.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.No)
            {
                this.Close();
                Application.Exit();
            }
            else if (x == DialogResult.Yes)
            {
                DialogResult d;
                d = MessageBox.Show("LAST WARNING!!!! If you clicked Yes then there's no coming back!! Are you sure you want to continue?", "LAST WARNING By Ultra_Ransomware.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                {
                    this.Close();
                    Application.Exit();
                }
                else if (d == DialogResult.Yes)
                {
                    //The function of the Ransomware

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '\u39CF';
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
