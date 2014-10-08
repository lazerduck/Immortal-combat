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
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            resources.main_menu.Show();
            resources.close_game = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //store the difficulty setting
            if (comboBox1.Text == "Easy")
            {
                resources.difficulty = 0;
            }
            if (comboBox1.Text == "Hard")
            {
                resources.difficulty = 1;
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            //save the settings and closet the form
            int chance_temp = 0;
            if (cheat_mode.Checked)
            {
                resources.cheat_mode = true;
            }
            else
            {
                resources.cheat_mode = false;
            }
            if (chance_input.Text.Length > 3)
            {
                chance_input.Text = "";
                label3.Visible = true;
            }
            //check if the inputs are within range
            try
            {
                chance_temp = Convert.ToInt32(chance_input.Text);
                if (chance_temp > 100)
                {
                    chance_input.Text = "";
                    label3.Visible = true;
                }
                else
                {
                    resources.main_menu.Show();
                    resources.close_game = true;
                    resources.random_chance = chance_temp;
                    this.Close();
                }
            }
            catch (Exception a)
            {
                chance_input.Text = "";
                label3.Visible = true;
            }
                if (wait_bx.Text.Length > 2)
            {
                chance_input.Text = resources.wait_time.ToString();
                label3.Visible = true;
            }
            try
            {
                chance_temp = Convert.ToInt32(wait_bx.Text);
                if (chance_temp < 0 && chance_temp > 10)
                {
                    chance_input.Text = "";
                    label3.Visible = true;
                }
                else
                {
                    resources.main_menu.Show();
                    resources.close_game = true;
                    resources.wait_time = chance_temp;
                    this.Close();
                }
            }
            catch (Exception q)
            {
                chance_input.Text = "";
                label3.Visible = true;
            }
        }
    }
}
