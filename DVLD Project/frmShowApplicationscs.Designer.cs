namespace DVLD_Project
{
    partial class frmShowApplicationscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowApplicationscs));
            this.txtSearchUsers = new System.Windows.Forms.TextBox();
            this.cmbSearchApplications = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecor = new System.Windows.Forms.Label();
            this.dvgApplications = new System.Windows.Forms.DataGridView();
            this.cntxApplicatoins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxShowApplictionDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxSechduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxcntxSechduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxSechduleStreetTests = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgApplications)).BeginInit();
            this.cntxApplicatoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchUsers
            // 
            this.txtSearchUsers.Location = new System.Drawing.Point(351, 224);
            this.txtSearchUsers.Multiline = true;
            this.txtSearchUsers.Name = "txtSearchUsers";
            this.txtSearchUsers.Size = new System.Drawing.Size(191, 24);
            this.txtSearchUsers.TabIndex = 31;
            this.txtSearchUsers.TextChanged += new System.EventHandler(this.txtSearchUsers_TextChanged);
            // 
            // cmbSearchApplications
            // 
            this.cmbSearchApplications.FormattingEnabled = true;
            this.cmbSearchApplications.Location = new System.Drawing.Point(152, 224);
            this.cmbSearchApplications.Name = "cmbSearchApplications";
            this.cmbSearchApplications.Size = new System.Drawing.Size(184, 24);
            this.cmbSearchApplications.TabIndex = 29;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(158, 661);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 29);
            this.lblRecords.TabIndex = 28;
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(15, 661);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 27;
            this.lblRecor.Text = "#Records : ";
            // 
            // dvgApplications
            // 
            this.dvgApplications.AllowUserToAddRows = false;
            this.dvgApplications.AllowUserToDeleteRows = false;
            this.dvgApplications.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgApplications.ContextMenuStrip = this.cntxApplicatoins;
            this.dvgApplications.Location = new System.Drawing.Point(20, 276);
            this.dvgApplications.Name = "dvgApplications";
            this.dvgApplications.ReadOnly = true;
            this.dvgApplications.RowHeadersWidth = 51;
            this.dvgApplications.RowTemplate.Height = 24;
            this.dvgApplications.Size = new System.Drawing.Size(1173, 371);
            this.dvgApplications.TabIndex = 25;
            this.dvgApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgApplications_CellContentClick);
            this.dvgApplications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgApplications_MouseDown);
            // 
            // cntxApplicatoins
            // 
            this.cntxApplicatoins.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxApplicatoins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxShowApplictionDetails,
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.cntxDelete,
            this.toolStripSeparator3,
            this.cntxCancelApplication,
            this.cntxSechduleTests,
            this.toolStripSeparator4,
            this.cntxIssueDrivingLicense,
            this.toolStripSeparator5,
            this.cntxShowLicense,
            this.toolStripSeparator6,
            this.cntxShowPersonLicenseHistory});
            this.cntxApplicatoins.Name = "cntxPeoples";
            this.cntxApplicatoins.Size = new System.Drawing.Size(306, 338);
            this.cntxApplicatoins.Opening += new System.ComponentModel.CancelEventHandler(this.cntxApplicatoins_Opening_1);
            // 
            // cntxShowApplictionDetails
            // 
            this.cntxShowApplictionDetails.Image = ((System.Drawing.Image)(resources.GetObject("cntxShowApplictionDetails.Image")));
            this.cntxShowApplictionDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxShowApplictionDetails.Name = "cntxShowApplictionDetails";
            this.cntxShowApplictionDetails.Size = new System.Drawing.Size(305, 38);
            this.cntxShowApplictionDetails.Text = "Show Application Details";
            this.cntxShowApplictionDetails.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(302, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(305, 38);
            this.toolStripMenuItem3.Text = "Edit Application";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cntxDelete
            // 
            this.cntxDelete.Image = ((System.Drawing.Image)(resources.GetObject("cntxDelete.Image")));
            this.cntxDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxDelete.Name = "cntxDelete";
            this.cntxDelete.Size = new System.Drawing.Size(305, 38);
            this.cntxDelete.Text = "Delete";
            this.cntxDelete.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(302, 6);
            // 
            // cntxCancelApplication
            // 
            this.cntxCancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("cntxCancelApplication.Image")));
            this.cntxCancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxCancelApplication.Name = "cntxCancelApplication";
            this.cntxCancelApplication.Size = new System.Drawing.Size(305, 38);
            this.cntxCancelApplication.Text = "Cancel Application";
            this.cntxCancelApplication.Click += new System.EventHandler(this.cntxCancelApplication_Click);
            // 
            // cntxSechduleTests
            // 
            this.cntxSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxSechduleVisionTest,
            this.cntxcntxSechduleWrittenTest,
            this.cntxSechduleStreetTests});
            this.cntxSechduleTests.Image = ((System.Drawing.Image)(resources.GetObject("cntxSechduleTests.Image")));
            this.cntxSechduleTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxSechduleTests.Name = "cntxSechduleTests";
            this.cntxSechduleTests.Size = new System.Drawing.Size(305, 38);
            this.cntxSechduleTests.Text = "Sechdule Tests";
            this.cntxSechduleTests.Click += new System.EventHandler(this.cntxSechduleTests_Click);
            // 
            // cntxSechduleVisionTest
            // 
            this.cntxSechduleVisionTest.Image = global::DVLD_Project.Properties.Resources.Vision_Test_32;
            this.cntxSechduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxSechduleVisionTest.Name = "cntxSechduleVisionTest";
            this.cntxSechduleVisionTest.Size = new System.Drawing.Size(257, 38);
            this.cntxSechduleVisionTest.Text = "Sechdule Vision Tests";
            this.cntxSechduleVisionTest.Click += new System.EventHandler(this.cntxSechduleVisionTest_Click);
            // 
            // cntxcntxSechduleWrittenTest
            // 
            this.cntxcntxSechduleWrittenTest.Image = global::DVLD_Project.Properties.Resources.Written_Test_32;
            this.cntxcntxSechduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxcntxSechduleWrittenTest.Name = "cntxcntxSechduleWrittenTest";
            this.cntxcntxSechduleWrittenTest.Size = new System.Drawing.Size(257, 38);
            this.cntxcntxSechduleWrittenTest.Text = "Sechdule  Written Tests";
            this.cntxcntxSechduleWrittenTest.Click += new System.EventHandler(this.cntxcntxSechduleWrittenTest_Click);
            // 
            // cntxSechduleStreetTests
            // 
            this.cntxSechduleStreetTests.Image = global::DVLD_Project.Properties.Resources.Street_Test_32;
            this.cntxSechduleStreetTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxSechduleStreetTests.Name = "cntxSechduleStreetTests";
            this.cntxSechduleStreetTests.Size = new System.Drawing.Size(257, 38);
            this.cntxSechduleStreetTests.Text = "Sechdule StreetTests";
            this.cntxSechduleStreetTests.Click += new System.EventHandler(this.cntxSechduleStreetTests_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(302, 6);
            // 
            // cntxIssueDrivingLicense
            // 
            this.cntxIssueDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("cntxIssueDrivingLicense.Image")));
            this.cntxIssueDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxIssueDrivingLicense.Name = "cntxIssueDrivingLicense";
            this.cntxIssueDrivingLicense.Size = new System.Drawing.Size(305, 38);
            this.cntxIssueDrivingLicense.Text = " Issue Driving License(First time)";
            this.cntxIssueDrivingLicense.Click += new System.EventHandler(this.cntxIssueDrivingLicense_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(302, 6);
            // 
            // cntxShowLicense
            // 
            this.cntxShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("cntxShowLicense.Image")));
            this.cntxShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxShowLicense.Name = "cntxShowLicense";
            this.cntxShowLicense.Size = new System.Drawing.Size(305, 38);
            this.cntxShowLicense.Text = "Show License";
            this.cntxShowLicense.Click += new System.EventHandler(this.cntxShowLicense_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(302, 6);
            // 
            // cntxShowPersonLicenseHistory
            // 
            this.cntxShowPersonLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("cntxShowPersonLicenseHistory.Image")));
            this.cntxShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxShowPersonLicenseHistory.Name = "cntxShowPersonLicenseHistory";
            this.cntxShowPersonLicenseHistory.Size = new System.Drawing.Size(305, 38);
            this.cntxShowPersonLicenseHistory.Text = "Show Person License History";
            this.cntxShowPersonLicenseHistory.Click += new System.EventHandler(this.cntxShowPersonLicenseHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(356, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Local Driving License Applications";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filter By : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DVLD_Project.Properties.Resources.Local_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(682, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 40);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(1046, 653);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 26;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.Applications;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(543, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 144);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::DVLD_Project.Properties.Resources.New_Application_64;
            this.btnAddUser.Location = new System.Drawing.Point(1103, 186);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 84);
            this.btnAddUser.TabIndex = 22;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmShowApplicationscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 707);
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
            this.Name = "frmShowApplicationscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Applicationscs";
            this.Load += new System.EventHandler(this.frmShowApplicationscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgApplications)).EndInit();
            this.cntxApplicatoins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip cntxApplicatoins;
        private System.Windows.Forms.ToolStripMenuItem cntxShowApplictionDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cntxDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cntxCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem cntxSechduleTests;
        private System.Windows.Forms.ToolStripMenuItem cntxSechduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem cntxcntxSechduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem cntxSechduleStreetTests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cntxIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cntxShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cntxShowPersonLicenseHistory;
    }
}