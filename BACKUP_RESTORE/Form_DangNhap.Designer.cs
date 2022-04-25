
namespace BACKUP_RESTORE
{
    partial class Form_DangNhap
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
            this.groupBox_dangnhap = new System.Windows.Forms.GroupBox();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.checkBox_show = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_servername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_servername = new System.Windows.Forms.Label();
            this.groupBox_dangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_dangnhap
            // 
            this.groupBox_dangnhap.Controls.Add(this.button_thoat);
            this.groupBox_dangnhap.Controls.Add(this.button_dangnhap);
            this.groupBox_dangnhap.Controls.Add(this.checkBox_show);
            this.groupBox_dangnhap.Controls.Add(this.textBox_password);
            this.groupBox_dangnhap.Controls.Add(this.textBox_username);
            this.groupBox_dangnhap.Controls.Add(this.textBox_servername);
            this.groupBox_dangnhap.Controls.Add(this.label3);
            this.groupBox_dangnhap.Controls.Add(this.label2);
            this.groupBox_dangnhap.Controls.Add(this.label_servername);
            this.groupBox_dangnhap.Location = new System.Drawing.Point(91, 39);
            this.groupBox_dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_dangnhap.Name = "groupBox_dangnhap";
            this.groupBox_dangnhap.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_dangnhap.Size = new System.Drawing.Size(613, 340);
            this.groupBox_dangnhap.TabIndex = 0;
            this.groupBox_dangnhap.TabStop = false;
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(366, 249);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(113, 28);
            this.button_thoat.TabIndex = 8;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Location = new System.Drawing.Point(161, 249);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(113, 28);
            this.button_dangnhap.TabIndex = 7;
            this.button_dangnhap.Text = "Đăng Nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // checkBox_show
            // 
            this.checkBox_show.AutoSize = true;
            this.checkBox_show.Location = new System.Drawing.Point(485, 205);
            this.checkBox_show.Name = "checkBox_show";
            this.checkBox_show.Size = new System.Drawing.Size(60, 21);
            this.checkBox_show.TabIndex = 6;
            this.checkBox_show.Text = "Show";
            this.checkBox_show.UseVisualStyleBackColor = true;
            this.checkBox_show.CheckedChanged += new System.EventHandler(this.checkBox_show_CheckedChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(161, 203);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(318, 25);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(161, 158);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(318, 25);
            this.textBox_username.TabIndex = 4;
            // 
            // textBox_servername
            // 
            this.textBox_servername.Enabled = false;
            this.textBox_servername.Location = new System.Drawing.Point(161, 82);
            this.textBox_servername.Name = "textBox_servername";
            this.textBox_servername.Size = new System.Drawing.Size(318, 25);
            this.textBox_servername.TabIndex = 3;
            this.textBox_servername.Text = "ANHDAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label_servername
            // 
            this.label_servername.AutoSize = true;
            this.label_servername.Location = new System.Drawing.Point(73, 82);
            this.label_servername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_servername.Name = "label_servername";
            this.label_servername.Size = new System.Drawing.Size(79, 17);
            this.label_servername.TabIndex = 0;
            this.label_servername.Text = "Servername";
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 458);
            this.Controls.Add(this.groupBox_dangnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DangNhap";
            this.Text = "Form_DangNhap";
            this.Load += new System.EventHandler(this.Form_DangNhap_Load);
            this.groupBox_dangnhap.ResumeLayout(false);
            this.groupBox_dangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_dangnhap;
        private System.Windows.Forms.CheckBox checkBox_show;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_servername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_servername;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_dangnhap;
    }
}