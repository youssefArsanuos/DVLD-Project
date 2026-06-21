namespace DVLD_Project
{
    partial class frmAppointmentTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentTest));
            this.picPagePicture = new System.Windows.Forms.PictureBox();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecor = new System.Windows.Forms.Label();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.dvgAppointments = new System.Windows.Forms.DataGridView();
            this.cntxAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cntxSechduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxcntxSechduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxSechduleStreetTests = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrLicenseApplicationInfo1 = new DVLD_Project.ctrLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.picPagePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppointments)).BeginInit();
            this.cntxAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPagePicture
            // 
            this.picPagePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPagePicture.Image = global::DVLD_Project.Properties.Resources.Vision_512;
            this.picPagePicture.InitialImage = null;
            this.picPagePicture.Location = new System.Drawing.Point(103, 0);
            this.picPagePicture.Name = "picPagePicture";
            this.picPagePicture.Size = new System.Drawing.Size(188, 141);
            this.picPagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPagePicture.TabIndex = 1;
            this.picPagePicture.TabStop = false;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.Red;
            this.lblPageTitle.Location = new System.Drawing.Point(368, 58);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(346, 32);
            this.lblPageTitle.TabIndex = 25;
            this.lblPageTitle.Text = "Vision Test Appointment";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(168, 813);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 29);
            this.lblRecords.TabIndex = 32;
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(29, 813);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 31;
            this.lblRecor.Text = "#Records : ";
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserFrm.Image")));
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(807, 805);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 30;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // dvgAppointments
            // 
            this.dvgAppointments.AllowUserToAddRows = false;
            this.dvgAppointments.AllowUserToDeleteRows = false;
            this.dvgAppointments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAppointments.ContextMenuStrip = this.cntxAppointment;
            this.dvgAppointments.Location = new System.Drawing.Point(34, 606);
            this.dvgAppointments.Name = "dvgAppointments";
            this.dvgAppointments.ReadOnly = true;
            this.dvgAppointments.RowHeadersWidth = 51;
            this.dvgAppointments.RowTemplate.Height = 24;
            this.dvgAppointments.Size = new System.Drawing.Size(920, 193);
            this.dvgAppointments.TabIndex = 29;
            this.dvgAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUser_CellContentClick);
            this.dvgAppointments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgAppointments_MouseDown);
            // 
            // cntxAppointment
            // 
            this.cntxAppointment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.cntxAppointment.Name = "cntxPeoples";
            this.cntxAppointment.Size = new System.Drawing.Size(154, 80);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 38);
            this.toolStripMenuItem3.Text = "Edit ";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::DVLD_Project.Properties.Resources.Test_32;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(153, 38);
            this.toolStripMenuItem4.Text = "Take Test";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Image = global::DVLD_Project.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(904, 556);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(50, 47);
            this.btnAddAppointment.TabIndex = 27;
            this.btnAddAppointment.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Appointments :";
            // 
            // cntxSechduleVisionTest
            // 
            this.cntxSechduleVisionTest.Image = global::DVLD_Project.Properties.Resources.Vision_Test_32;
            this.cntxSechduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxSechduleVisionTest.Name = "cntxSechduleVisionTest";
            this.cntxSechduleVisionTest.Size = new System.Drawing.Size(301, 38);
            this.cntxSechduleVisionTest.Text = "Sechdule Vision Tests";
            // 
            // cntxcntxSechduleWrittenTest
            // 
            this.cntxcntxSechduleWrittenTest.Image = global::DVLD_Project.Properties.Resources.Written_Test_32;
            this.cntxcntxSechduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxcntxSechduleWrittenTest.Name = "cntxcntxSechduleWrittenTest";
            this.cntxcntxSechduleWrittenTest.Size = new System.Drawing.Size(301, 38);
            this.cntxcntxSechduleWrittenTest.Text = "Sechdule  Written Tests";
            // 
            // cntxSechduleStreetTests
            // 
            this.cntxSechduleStreetTests.Image = global::DVLD_Project.Properties.Resources.Street_Test_32;
            this.cntxSechduleStreetTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxSechduleStreetTests.Name = "cntxSechduleStreetTests";
            this.cntxSechduleStreetTests.Size = new System.Drawing.Size(301, 38);
            this.cntxSechduleStreetTests.Text = "Sechdule StreetTests";
            // 
            // ctrLicenseApplicationInfo1
            // 
            this.ctrLicenseApplicationInfo1.ApplicationId = 0;
            this.ctrLicenseApplicationInfo1.LDLAId = null;
            this.ctrLicenseApplicationInfo1.LicenseClassId = 0;
            this.ctrLicenseApplicationInfo1.Location = new System.Drawing.Point(34, 137);
            this.ctrLicenseApplicationInfo1.Name = "ctrLicenseApplicationInfo1";
            this.ctrLicenseApplicationInfo1.PersonId = 0;
            this.ctrLicenseApplicationInfo1.Size = new System.Drawing.Size(932, 421);
            this.ctrLicenseApplicationInfo1.TabIndex = 0;
            this.ctrLicenseApplicationInfo1.UserId = 0;
            // 
            // frmAppointmentTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 862);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecor);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.dvgAppointments);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.picPagePicture);
            this.Controls.Add(this.ctrLicenseApplicationInfo1);
            this.Name = "frmAppointmentTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Test";
            this.Load += new System.EventHandler(this.frmAppointmentTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPagePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppointments)).EndInit();
            this.cntxAppointment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrLicenseApplicationInfo ctrLicenseApplicationInfo1;
        private System.Windows.Forms.PictureBox picPagePicture;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecor;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.DataGridView dvgAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cntxAppointment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cntxSechduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem cntxcntxSechduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem cntxSechduleStreetTests;
    }
}