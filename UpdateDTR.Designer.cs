
namespace HRTimekeeping
{
    partial class UpdateDTR
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbmname = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tbsname = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.timeout = new System.Windows.Forms.DateTimePicker();
            this.tbempid = new System.Windows.Forms.TextBox();
            this.timein = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(592, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(511, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbmname
            // 
            this.tbmname.Location = new System.Drawing.Point(459, 116);
            this.tbmname.Name = "tbmname";
            this.tbmname.Size = new System.Drawing.Size(195, 26);
            this.tbmname.TabIndex = 13;
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(240, 116);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(195, 26);
            this.tbfname.TabIndex = 12;
            // 
            // tbsname
            // 
            this.tbsname.Location = new System.Drawing.Point(29, 116);
            this.tbsname.Name = "tbsname";
            this.tbsname.Size = new System.Drawing.Size(195, 26);
            this.tbsname.TabIndex = 11;
            // 
            // date
            // 
            this.date.CustomFormat = "MM/dd/yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(176, 40);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(119, 26);
            this.date.TabIndex = 10;
            // 
            // timeout
            // 
            this.timeout.CustomFormat = "HH:mm:ss";
            this.timeout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeout.Location = new System.Drawing.Point(490, 188);
            this.timeout.Name = "timeout";
            this.timeout.ShowUpDown = true;
            this.timeout.Size = new System.Drawing.Size(77, 26);
            this.timeout.TabIndex = 9;
            this.timeout.Value = new System.DateTime(2022, 8, 3, 0, 0, 0, 0);
            // 
            // tbempid
            // 
            this.tbempid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbempid.Location = new System.Drawing.Point(176, 73);
            this.tbempid.Name = "tbempid";
            this.tbempid.Size = new System.Drawing.Size(100, 26);
            this.tbempid.TabIndex = 8;
            // 
            // timein
            // 
            this.timein.CustomFormat = "HH:mm:ss";
            this.timein.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timein.Location = new System.Drawing.Point(229, 187);
            this.timein.Name = "timein";
            this.timein.ShowUpDown = true;
            this.timein.Size = new System.Drawing.Size(77, 26);
            this.timein.TabIndex = 7;
            this.timein.Value = new System.DateTime(2022, 8, 3, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Time Out :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Time In :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employee ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Log :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbmname);
            this.groupBox1.Controls.Add(this.tbfname);
            this.groupBox1.Controls.Add(this.tbsname);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.timeout);
            this.groupBox1.Controls.Add(this.tbempid);
            this.groupBox1.Controls.Add(this.timein);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fields";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Update DTR";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(649, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 13);
            this.id.TabIndex = 16;
            this.id.Visible = false;
            // 
            // UpdateDTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 336);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDTR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDTR";
            this.Load += new System.EventHandler(this.UpdateDTR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label id;
        public System.Windows.Forms.TextBox tbmname;
        public System.Windows.Forms.TextBox tbfname;
        public System.Windows.Forms.TextBox tbsname;
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.DateTimePicker timeout;
        public System.Windows.Forms.TextBox tbempid;
        public System.Windows.Forms.DateTimePicker timein;
    }
}