namespace Graphic
{
    partial class frm_SettingForm
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
            this.btn_returntomainmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_AsiabSp = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_AsiabSp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_returntomainmenu
            // 
            this.btn_returntomainmenu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_returntomainmenu.FlatAppearance.BorderSize = 2;
            this.btn_returntomainmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btn_returntomainmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_returntomainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_returntomainmenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returntomainmenu.Location = new System.Drawing.Point(244, 105);
            this.btn_returntomainmenu.Name = "btn_returntomainmenu";
            this.btn_returntomainmenu.Size = new System.Drawing.Size(97, 36);
            this.btn_returntomainmenu.TabIndex = 4;
            this.btn_returntomainmenu.Text = "بازگشت";
            this.btn_returntomainmenu.UseVisualStyleBackColor = true;
            this.btn_returntomainmenu.Click += new System.EventHandler(this.btn_returntomainmenu_Click);
            this.btn_returntomainmenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SettingForm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "سرعت آسیاب";
            // 
            // tb_AsiabSp
            // 
            this.tb_AsiabSp.Location = new System.Drawing.Point(244, 39);
            this.tb_AsiabSp.Name = "tb_AsiabSp";
            this.tb_AsiabSp.Size = new System.Drawing.Size(222, 45);
            this.tb_AsiabSp.TabIndex = 13;
            this.tb_AsiabSp.ValueChanged += new System.EventHandler(this.tb_AsiabSp_ValueChanged);
            this.tb_AsiabSp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SettingForm_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "کند";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "تند";
            // 
            // frm_SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(526, 179);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_AsiabSp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_returntomainmenu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_SettingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SettingForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tb_AsiabSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_returntomainmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_AsiabSp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}