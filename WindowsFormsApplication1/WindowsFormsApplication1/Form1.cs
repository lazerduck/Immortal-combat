using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splash_screen splash = new splash_screen();
            splash.Show();
            resources.main_menu = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_game main = new main_game();
            resources.game = main;
            main.Show();
            this.Hide();
        }

        private void options_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            options option = new options();
            option.Show();
        }
    }
}
