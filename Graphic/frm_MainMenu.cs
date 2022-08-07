using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphic
{
    public partial class frm_MainMenu : Form
    {
        public frm_MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!Program.IsStarted)
            {
                frm_main m = new frm_main();
                m.ShowDialog();
            }
            this.Close();
        }

        private void frm_MainMenu_Load(object sender, EventArgs e)
        {
            if (Program.IsStarted)
            {
                btn_Start.Text = "ادامه";
            }
            else
            {
                btn_Start.Text = "شروع";
                groupBox1.Visible = true;
                My_Timer.Start();
            }
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            frm_SettingForm stf = new frm_SettingForm();
            stf.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_returntogame_Click(object sender, EventArgs e)
        {
            frm_MainMenu.ActiveForm.Close();
        }

        private void btn_Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                frm_MainMenu.ActiveForm.Close();
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            frm_Help fh = new frm_Help();
            fh.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int Counter = 0;

        private void My_Timer_Tick(object sender, EventArgs e)
        {
            if(Counter == 50)
            {
                groupBox1.Visible= false;
                My_Timer.Stop();
                My_Timer.Dispose();
            }
            Counter++;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
