
namespace HRTimekeeping
{
    partial class Addposition
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsupervisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbposition = new System.Windows.Forms.TextBox();
            this.tbok = new System.Windows.Forms.Button();
            this.tbcancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 44);
            this.label3.TabIndex = 20;
            this.label3.Text = "Insert Position";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbsupervisor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbposition);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 133);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Superior/Supervisor :";
            // 
            // tbsupervisor
            // 
            this.tbsupervisor.Location = new System.Drawing.Point(211, 77);
            this.tbsupervisor.Name = "tbsupervisor";
            this.tbsupervisor.Size = new System.Drawing.Size(263, 26);
            this.tbsupervisor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position :";
            // 
            // tbposition
            // 
            this.tbposition.Location = new System.Drawing.Point(211, 34);
            this.tbposition.Name = "tbposition";
            this.tbposition.Size = new System.Drawing.Size(263, 26);
            this.tbposition.TabIndex = 0;
            // 
            // tbok
            // 
            this.tbok.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbok.Location = new System.Drawing.Point(345, 273);
            this.tbok.Name = "tbok";
            this.tbok.Size = new System.Drawing.Size(87, 39);
            this.tbok.TabIndex = 22;
            this.tbok.Text = "Ok";
            this.tbok.UseVisualStyleBackColor = true;
            this.tbok.Click += new System.EventHandler(this.tbok_Click);
            // 
            // tbcancel
            // 
            this.tbcancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcancel.Location = new System.Drawing.Point(438, 273);
            this.tbcancel.Name = "tbcancel";
            this.tbcancel.Size = new System.Drawing.Size(87, 39);
            this.tbcancel.TabIndex = 23;
            this.tbcancel.Text = "Cancel";
            this.tbcancel.UseVisualStyleBackColor = true;
            this.tbcancel.Click += new System.EventHandler(this.tbcancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRTimekeeping.Properties.Resources.Kings_Logo_copy_80x;
            this.pictureBox1.Location = new System.Drawing.Point(27, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Addposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 324);
            this.Controls.Add(this.tbcancel);
            this.Controls.Add(this.tbok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Addposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addposition";
            this.Load += new System.EventHandler(this.Addposition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbposition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsupervisor;
        private System.Windows.Forms.Button tbok;
        private System.Windows.Forms.Button tbcancel;
    }
}