namespace DVLD_Project
{
    partial class frmShowInternationalLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternationalLicenses));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchUsers = new System.Windows.Forms.TextBox();
            this.cmbSearchApplications = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecor = new System.Windows.Forms.Label();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.dvgApplications = new System.Windows.Forms.DataGridView();
            this.cntxApplicatoins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxShowApplictionDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbxLicensesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgApplications)).BeginInit();
            this.cntxApplicatoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DVLD_Project.Properties.Resources.International_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(674, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 40);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchUsers
            // 
            this.txtSearchUsers.Location = new System.Drawing.Point(343, 233);
            this.txtSearchUsers.Multiline = true;
            this.txtSearchUsers.Name = "txtSearchUsers";
            this.txtSearchUsers.Size = new System.Drawing.Size(191, 24);
            this.txtSearchUsers.TabIndex = 42;
            this.txtSearchUsers.TextChanged += new System.EventHandler(this.txtSearchUsers_TextChanged);
            // 
            // cmbSearchApplications
            // 
            this.cmbSearchApplications.FormattingEnabled = true;
            this.cmbSearchApplications.Location = new System.Drawing.Point(144, 233);
            this.cmbSearchApplications.Name = "cmbSearchApplications";
            this.cmbSearchApplications.Size = new System.Drawing.Size(184, 24);
            this.cmbSearchApplications.TabIndex = 41;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(150, 670);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 29);
            this.lblRecords.TabIndex = 40;
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(7, 670);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 39;
            this.lblRecor.Text = "#Records : ";
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(1038, 662);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 38;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // dvgApplications
            // 
            this.dvgApplications.AllowUserToAddRows = false;
            this.dvgApplications.AllowUserToDeleteRows = false;
            this.dvgApplications.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgApplications.ContextMenuStrip = this.cntxApplicatoins;
            this.dvgApplications.Location = new System.Drawing.Point(12, 285);
            this.dvgApplications.Name = "dvgApplications";
            this.dvgApplications.ReadOnly = true;
            this.dvgApplications.RowHeadersWidth = 51;
            this.dvgApplications.RowTemplate.Height = 24;
            this.dvgApplications.Size = new System.Drawing.Size(1173, 371);
            this.dvgApplications.TabIndex = 37;
            this.dvgApplications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgApplications_MouseDown);
            // 
            // cntxApplicatoins
            // 
            this.cntxApplicatoins.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxApplicatoins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxShowApplictionDetails,
            this.toolStripSeparator4,
            this.cntxShowLicense,
            this.toolStripSeparator6,
            this.cmbxLicensesHistory});
            this.cntxApplicatoins.Name = "cntxPeoples";
            this.cntxApplicatoins.Size = new System.Drawing.Size(233, 130);
            // 
            // cntxShowApplictionDetails
            // 
            this.cntxShowApplictionDetails.Image = ((System.Drawing.Image)(resources.GetObject("cntxShowApplictionDetails.Image")));
            this.cntxShowApplictionDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxShowApplictionDetails.Name = "cntxShowApplictionDetails";
            this.cntxShowApplictionDetails.Size = new System.Drawing.Size(232, 38);
            this.cntxShowApplictionDetails.Text = "Show Person Details";
            this.cntxShowApplictionDetails.Click += new System.EventHandler(this.cntxShowApplictionDetails_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(229, 6);
            // 
            // cntxShowLicense
            // 
            this.cntxShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("cntxShowLicense.Image")));
            this.cntxShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxShowLicense.Name = "cntxShowLicense";
            this.cntxShowLicense.Size = new System.Drawing.Size(232, 38);
            this.cntxShowLicense.Text = "Show License Details";
            this.cntxShowLicense.Click += new System.EventHandler(this.cntxShowLicense_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(229, 6);
            // 
            // cmbxLicensesHistory
            // 
            this.cmbxLicensesHistory.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.cmbxLicensesHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmbxLicensesHistory.Name = "cmbxLicensesHistory";
            this.cmbxLicensesHistory.Size = new System.Drawing.Size(232, 38);
            this.cmbxLicensesHistory.Text = "Licenses History";
            this.cmbxLicensesHistory.Click += new System.EventHandler(this.cmbxLicensesHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(319, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "International Driving License Applications";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.Applications;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(535, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 144);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::DVLD_Project.Properties.Resources.New_Application_64;
            this.btnAddUser.Location = new System.Drawing.Point(1095, 195);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 84);
            this.btnAddUser.TabIndex = 34;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Filter By : ";
            // 
            // frmShowInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 725);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearchUsers);
            this.Controls.Add(this.cmbSearchApplications);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecor);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.dvgApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label3);
            this.Name = "frmShowInternationalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Show International Licenses";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgApplications)).EndInit();
            this.cntxApplicatoins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchUsers;
        private System.Windows.Forms.ComboBox cmbSearchApplications;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecor;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.DataGridView dvgApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cntxApplicatoins;
        private System.Windows.Forms.ToolStripMenuItem cntxShowApplictionDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cntxShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cmbxLicensesHistory;
    }
}