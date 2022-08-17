
namespace HRTimekeeping
{
    partial class OTReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.tbsegment = new System.Windows.Forms.TextBox();
            this.btnpreview = new System.Windows.Forms.Button();
            this.tbposition = new System.Windows.Forms.TextBox();
            this.tbdept = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbsupervisor = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.empot1 = new HRTimekeeping.empot();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbsupervisor);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.tbsegment);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.btnpreview);
            this.panel1.Controls.Add(this.tbposition);
            this.panel1.Controls.Add(this.tbdept);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(213, 41);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(35, 13);
            this.id.TabIndex = 18;
            this.id.Text = "label1";
            // 
            // tbsegment
            // 
            this.tbsegment.Location = new System.Drawing.Point(60, 269);
            this.tbsegment.Name = "tbsegment";
            this.tbsegment.Size = new System.Drawing.Size(182, 20);
            this.tbsegment.TabIndex = 17;
            // 
            // btnpreview
            // 
            this.btnpreview.Location = new System.Drawing.Point(77, 321);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(75, 23);
            this.btnpreview.TabIndex = 15;
            this.btnpreview.Text = "Preview";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // tbposition
            // 
            this.tbposition.Location = new System.Drawing.Point(60, 243);
            this.tbposition.Name = "tbposition";
            this.tbposition.Size = new System.Drawing.Size(182, 20);
            this.tbposition.TabIndex = 14;
            // 
            // tbdept
            // 
            this.tbdept.Location = new System.Drawing.Point(60, 204);
            this.tbdept.Name = "tbdept";
            this.tbdept.Size = new System.Drawing.Size(182, 20);
            this.tbdept.TabIndex = 13;
            // 
            // date2
            // 
            this.date2.CustomFormat = "MM/dd/yyyy";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(123, 162);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(119, 20);
            this.date2.TabIndex = 12;
            // 
            // date1
            // 
            this.date1.CustomFormat = "MM/dd/yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(123, 120);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(119, 20);
            this.date1.TabIndex = 11;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(60, 75);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(182, 20);
            this.tbname.TabIndex = 1;
            // 
            // tbsupervisor
            // 
            this.tbsupervisor.Location = new System.Drawing.Point(60, 295);
            this.tbsupervisor.Name = "tbsupervisor";
            this.tbsupervisor.Size = new System.Drawing.Size(182, 20);
            this.tbsupervisor.TabIndex = 19;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(287, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.empot1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(501, 444);
            this.crystalReportViewer1.TabIndex = 16;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OTReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OTReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.TextBox tbposition;
        public System.Windows.Forms.TextBox tbdept;
        private System.Windows.Forms.Button btnpreview;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private empot empot1;
        public System.Windows.Forms.TextBox tbsegment;
        public System.Windows.Forms.Label id;
        public System.Windows.Forms.TextBox tbsupervisor;
        private System.Windows.Forms.Button button1;
    }
}