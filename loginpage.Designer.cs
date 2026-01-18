namespace login_page1
{
    partial class loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn2clear = new System.Windows.Forms.Button();
            this.btn1login = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblpd = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(226, 272);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn2clear
            // 
            this.btn2clear.BackColor = System.Drawing.Color.Red;
            this.btn2clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2clear.Location = new System.Drawing.Point(285, 307);
            this.btn2clear.Name = "btn2clear";
            this.btn2clear.Size = new System.Drawing.Size(77, 40);
            this.btn2clear.TabIndex = 9;
            this.btn2clear.Text = "Clear";
            this.btn2clear.UseVisualStyleBackColor = false;
            this.btn2clear.Click += new System.EventHandler(this.btn2clear_Click);
            // 
            // btn1login
            // 
            this.btn1login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn1login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1login.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn1login.Location = new System.Drawing.Point(184, 307);
            this.btn1login.Name = "btn1login";
            this.btn1login.Size = new System.Drawing.Size(75, 40);
            this.btn1login.TabIndex = 10;
            this.btn1login.Text = "Login";
            this.btn1login.UseVisualStyleBackColor = false;
            this.btn1login.Click += new System.EventHandler(this.btn1login_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(226, 235);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(136, 20);
            this.txtpass.TabIndex = 7;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(226, 196);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(136, 20);
            this.txtuser.TabIndex = 8;
            // 
            // lblpd
            // 
            this.lblpd.AutoSize = true;
            this.lblpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpd.Location = new System.Drawing.Point(137, 237);
            this.lblpd.Name = "lblpd";
            this.lblpd.Size = new System.Drawing.Size(83, 18);
            this.lblpd.TabIndex = 5;
            this.lblpd.Text = "Password :";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(128, 196);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(92, 18);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "User Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(910, 444);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn2clear);
            this.Controls.Add(this.btn1login);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblpd);
            this.Controls.Add(this.lbluser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loginpage";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn2clear;
        private System.Windows.Forms.Button btn1login;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblpd;
        private System.Windows.Forms.Label lbluser;
    }
}