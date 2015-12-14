namespace HDPLC_TEST
{
    partial class Threshold
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_RefMac = new System.Windows.Forms.TextBox();
            this.tb_StdPhyRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vol1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vol1_dev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vol2_dev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_vol2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cur_dev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_cur = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "参考版MAC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHY速度最低值：";
            // 
            // tb_RefMac
            // 
            this.tb_RefMac.Location = new System.Drawing.Point(131, 26);
            this.tb_RefMac.Name = "tb_RefMac";
            this.tb_RefMac.Size = new System.Drawing.Size(118, 21);
            this.tb_RefMac.TabIndex = 2;
            // 
            // tb_StdPhyRate
            // 
            this.tb_StdPhyRate.Location = new System.Drawing.Point(131, 61);
            this.tb_StdPhyRate.Name = "tb_StdPhyRate";
            this.tb_StdPhyRate.Size = new System.Drawing.Size(118, 21);
            this.tb_StdPhyRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mbps";
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(95, 208);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(196, 208);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "返回";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "mV";
            // 
            // tb_vol1
            // 
            this.tb_vol1.Location = new System.Drawing.Point(132, 97);
            this.tb_vol1.Name = "tb_vol1";
            this.tb_vol1.Size = new System.Drawing.Size(70, 21);
            this.tb_vol1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "额定电压值1：";
            // 
            // tb_vol1_dev
            // 
            this.tb_vol1_dev.Location = new System.Drawing.Point(274, 98);
            this.tb_vol1_dev.Name = "tb_vol1_dev";
            this.tb_vol1_dev.Size = new System.Drawing.Size(55, 21);
            this.tb_vol1_dev.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "误差：";
            // 
            // tb_vol2_dev
            // 
            this.tb_vol2_dev.Location = new System.Drawing.Point(274, 132);
            this.tb_vol2_dev.Name = "tb_vol2_dev";
            this.tb_vol2_dev.Size = new System.Drawing.Size(55, 21);
            this.tb_vol2_dev.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "误差：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "mV";
            // 
            // tb_vol2
            // 
            this.tb_vol2.Location = new System.Drawing.Point(132, 131);
            this.tb_vol2.Name = "tb_vol2";
            this.tb_vol2.Size = new System.Drawing.Size(70, 21);
            this.tb_vol2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "额定电压值2：";
            // 
            // tb_cur_dev
            // 
            this.tb_cur_dev.Location = new System.Drawing.Point(274, 165);
            this.tb_cur_dev.Name = "tb_cur_dev";
            this.tb_cur_dev.Size = new System.Drawing.Size(55, 21);
            this.tb_cur_dev.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "误差：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "mA";
            // 
            // tb_cur
            // 
            this.tb_cur.Location = new System.Drawing.Point(132, 164);
            this.tb_cur.Name = "tb_cur";
            this.tb_cur.Size = new System.Drawing.Size(70, 21);
            this.tb_cur.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "整板电流：";
            // 
            // Threshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 254);
            this.Controls.Add(this.tb_cur_dev);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_cur);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_vol2_dev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_vol2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_vol1_dev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_vol1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_StdPhyRate);
            this.Controls.Add(this.tb_RefMac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Threshold";
            this.Text = "测试门限值设置";
            this.Load += new System.EventHandler(this.Threshold_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_RefMac;
        private System.Windows.Forms.TextBox tb_StdPhyRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_vol1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vol1_dev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vol2_dev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_vol2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_cur_dev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_cur;
        private System.Windows.Forms.Label label12;
    }
}