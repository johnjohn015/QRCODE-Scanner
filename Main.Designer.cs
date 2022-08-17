namespace HRTimekeeping
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblrole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbluser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mlts = new System.Windows.Forms.ToolStripButton();
            this.sts = new System.Windows.Forms.ToolStripDropDownButton();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deparmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actts = new System.Windows.Forms.ToolStripDropDownButton();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hrs = new System.Windows.Forms.ToolStripDropDownButton();
            this.dtrs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lblrole,
            this.toolStripStatusLabel2,
            this.lbluser});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblrole
            // 
            this.lblrole.BackColor = System.Drawing.Color.Transparent;
            this.lblrole.LinkColor = System.Drawing.Color.White;
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(30, 17);
            this.lblrole.Text = "Role";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.LinkColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel2.Text = "/";
            // 
            // lbluser
            // 
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.LinkColor = System.Drawing.Color.White;
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(30, 17);
            this.lbluser.Text = "User";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mlts,
            this.sts,
            this.hrs,
            this.toolStripDropDownButton1,
            this.actts,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 73);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mlts
            // 
            this.mlts.AutoSize = false;
            this.mlts.Image = global::HRTimekeeping.Properties.Resources.Apps_preferences_contact_list_icon;
            this.mlts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mlts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mlts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mlts.Name = "mlts";
            this.mlts.Size = new System.Drawing.Size(70, 70);
            this.mlts.Tag = "test";
            this.mlts.Text = "Masterlist";
            this.mlts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mlts.ToolTipText = "Masterlist";
            this.mlts.Click += new System.EventHandler(this.mlts_Click);
            // 
            // sts
            // 
            this.sts.AutoSize = false;
            this.sts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionToolStripMenuItem,
            this.deparmentToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.sts.Image = global::HRTimekeeping.Properties.Resources.Tools_icon;
            this.sts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(70, 70);
            this.sts.Tag = "test";
            this.sts.Text = "Setup";
            this.sts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sts.ToolTipText = "Setup";
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.positionToolStripMenuItem.Text = "Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.positionToolStripMenuItem_Click);
            // 
            // deparmentToolStripMenuItem
            // 
            this.deparmentToolStripMenuItem.Name = "deparmentToolStripMenuItem";
            this.deparmentToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deparmentToolStripMenuItem.Text = "Branch/Department";
            this.deparmentToolStripMenuItem.Click += new System.EventHandler(this.deparmentToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // actts
            // 
            this.actts.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.actts.AutoSize = false;
            this.actts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.actts.Image = global::HRTimekeeping.Properties.Resources.user_info_icon;
            this.actts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.actts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actts.Name = "actts";
            this.actts.Size = new System.Drawing.Size(70, 70);
            this.actts.Tag = "test";
            this.actts.Text = "Account";
            this.actts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.actts.ToolTipText = "Account";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Account Settings";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Log - out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::HRTimekeeping.Properties.Resources.checklist_icon__1_;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 70);
            this.toolStripButton1.Tag = "test";
            this.toolStripButton1.Text = "Daily Task";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Daily Task";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripDropDownButton1.Image = global::HRTimekeeping.Properties.Resources.Folder_Filing_icon;
            this.toolStripDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 70);
            this.toolStripDropDownButton1.Tag = "test";
            this.toolStripDropDownButton1.Text = "Filing";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownButton1.ToolTipText = "Filing";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Overtime";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // hrs
            // 
            this.hrs.AutoSize = false;
            this.hrs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dtrs});
            this.hrs.Image = global::HRTimekeeping.Properties.Resources.Calendar_icon;
            this.hrs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hrs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hrs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hrs.Name = "hrs";
            this.hrs.Size = new System.Drawing.Size(70, 70);
            this.hrs.Tag = "test";
            this.hrs.Text = "H.R.";
            this.hrs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hrs.ToolTipText = "Human Resources";
            // 
            // dtrs
            // 
            this.dtrs.Name = "dtrs";
            this.dtrs.Size = new System.Drawing.Size(180, 22);
            this.dtrs.Text = "DTR";
            this.dtrs.Click += new System.EventHandler(this.dtrs_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mlts;
        private System.Windows.Forms.ToolStripDropDownButton sts;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton actts;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deparmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel lblrole;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbluser;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripDropDownButton hrs;
        private System.Windows.Forms.ToolStripMenuItem dtrs;
    }
}



