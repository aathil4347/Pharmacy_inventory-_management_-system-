namespace login_page1
{
    partial class AddMedicine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblMname = new System.Windows.Forms.Label();
            this.lblMnumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPriceunit = new System.Windows.Forms.Label();
            this.medicinename = new System.Windows.Forms.TextBox();
            this.medicineid = new System.Windows.Forms.TextBox();
            this.medicinenumber = new System.Windows.Forms.TextBox();
            this.quanity = new System.Windows.Forms.TextBox();
            this.priceperunit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.expireddate = new System.Windows.Forms.DateTimePicker();
            this.manufacturedate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(953, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login_page1.Properties.Resources.images__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(361, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Medicine";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(159, 156);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 18);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Medicine Id";
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMname.Location = new System.Drawing.Point(159, 231);
            this.lblMname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(124, 18);
            this.lblMname.TabIndex = 3;
            this.lblMname.Text = "Medicine Name";
            // 
            // lblMnumber
            // 
            this.lblMnumber.AutoSize = true;
            this.lblMnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnumber.Location = new System.Drawing.Point(159, 315);
            this.lblMnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMnumber.Name = "lblMnumber";
            this.lblMnumber.Size = new System.Drawing.Size(139, 18);
            this.lblMnumber.TabIndex = 3;
            this.lblMnumber.Text = "Medicine Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Manufacturing Date";
            // 
            // lblEDate
            // 
            this.lblEDate.AutoSize = true;
            this.lblEDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDate.Location = new System.Drawing.Point(584, 156);
            this.lblEDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEDate.Name = "lblEDate";
            this.lblEDate.Size = new System.Drawing.Size(95, 18);
            this.lblEDate.TabIndex = 3;
            this.lblEDate.Text = "Expire Date";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(584, 231);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 18);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPriceunit
            // 
            this.lblPriceunit.AutoSize = true;
            this.lblPriceunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceunit.Location = new System.Drawing.Point(584, 315);
            this.lblPriceunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceunit.Name = "lblPriceunit";
            this.lblPriceunit.Size = new System.Drawing.Size(113, 18);
            this.lblPriceunit.TabIndex = 3;
            this.lblPriceunit.Text = "Price Per Unit";
            // 
            // medicinename
            // 
            this.medicinename.Location = new System.Drawing.Point(163, 254);
            this.medicinename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicinename.Name = "medicinename";
            this.medicinename.Size = new System.Drawing.Size(309, 22);
            this.medicinename.TabIndex = 4;
            // 
            // medicineid
            // 
            this.medicineid.Location = new System.Drawing.Point(163, 178);
            this.medicineid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicineid.Name = "medicineid";
            this.medicineid.Size = new System.Drawing.Size(309, 22);
            this.medicineid.TabIndex = 4;
            // 
            // medicinenumber
            // 
            this.medicinenumber.Location = new System.Drawing.Point(163, 337);
            this.medicinenumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicinenumber.Name = "medicinenumber";
            this.medicinenumber.Size = new System.Drawing.Size(309, 22);
            this.medicinenumber.TabIndex = 4;
            // 
            // quanity
            // 
            this.quanity.Location = new System.Drawing.Point(588, 254);
            this.quanity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quanity.Name = "quanity";
            this.quanity.Size = new System.Drawing.Size(301, 22);
            this.quanity.TabIndex = 4;
            // 
            // priceperunit
            // 
            this.priceperunit.Location = new System.Drawing.Point(588, 337);
            this.priceperunit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceperunit.Name = "priceperunit";
            this.priceperunit.Size = new System.Drawing.Size(301, 22);
            this.priceperunit.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(373, 489);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(545, 489);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 38);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // expireddate
            // 
            this.expireddate.Location = new System.Drawing.Point(588, 178);
            this.expireddate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expireddate.Name = "expireddate";
            this.expireddate.Size = new System.Drawing.Size(301, 22);
            this.expireddate.TabIndex = 6;
            // 
            // manufacturedate
            // 
            this.manufacturedate.Location = new System.Drawing.Point(163, 420);
            this.manufacturedate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manufacturedate.Name = "manufacturedate";
            this.manufacturedate.Size = new System.Drawing.Size(309, 22);
            this.manufacturedate.TabIndex = 7;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1119, 609);
            this.Controls.Add(this.manufacturedate);
            this.Controls.Add(this.expireddate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.medicineid);
            this.Controls.Add(this.priceperunit);
            this.Controls.Add(this.quanity);
            this.Controls.Add(this.medicinenumber);
            this.Controls.Add(this.medicinename);
            this.Controls.Add(this.lblPriceunit);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblEDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMnumber);
            this.Controls.Add(this.lblMname);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.Label lblMnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPriceunit;
        private System.Windows.Forms.TextBox medicinename;
        private System.Windows.Forms.TextBox medicineid;
        private System.Windows.Forms.TextBox medicinenumber;
        private System.Windows.Forms.TextBox quanity;
        private System.Windows.Forms.TextBox priceperunit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker expireddate;
        private System.Windows.Forms.DateTimePicker manufacturedate;
    }
}