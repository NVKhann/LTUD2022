
namespace QuanLiDIem
{
    partial class fDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.pbDN = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTenDN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 46);
            this.panel1.TabIndex = 1;
            // 
            // tbTenDN
            // 
            this.tbTenDN.Location = new System.Drawing.Point(159, 8);
            this.tbTenDN.Name = "tbTenDN";
            this.tbTenDN.Size = new System.Drawing.Size(240, 27);
            this.tbTenDN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbMK);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(28, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 46);
            this.panel2.TabIndex = 2;
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(159, 8);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(240, 27);
            this.tbMK.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:  ";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.BlueViolet;
            this.btnHuy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.Location = new System.Drawing.Point(181, 402);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDN.Location = new System.Drawing.Point(307, 402);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(120, 40);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // pbDN
            // 
            this.pbDN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbDN.Location = new System.Drawing.Point(142, 75);
            this.pbDN.Name = "pbDN";
            this.pbDN.Size = new System.Drawing.Size(200, 200);
            this.pbDN.TabIndex = 5;
            this.pbDN.TabStop = false;
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 463);
            this.Controls.Add(this.pbDN);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTenDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.PictureBox pbDN;
    }
}