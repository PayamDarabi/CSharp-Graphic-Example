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
    public partial class frm_SettingForm : Form
    {
        public frm_SettingForm()
        {
            InitializeComponent();
        }

        private void btn_returntomainmenu_Click(object sender, EventArgs e)
        {
            frm_SettingForm.ActiveForm.Close();
        }

        private void frm_SettingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frm_SettingForm.ActiveForm.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_SettingForm_Load(object sender, EventArgs e)
        {
            tb_AsiabSp.Value = Program.AsiabSpeed;
           
        }

        private void tb_AsiabSp_ValueChanged(object sender, EventArgs e)
        {
            Program.AsiabSpeed = tb_AsiabSp.Value;
        }

        private void tb_Catsp_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
