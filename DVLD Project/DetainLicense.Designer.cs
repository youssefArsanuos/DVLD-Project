namespace DVLD_Project
{
    partial class DetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetainLicense));
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.txtSearchLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrDriverLicenseInfo1 = new DVLD_Project.ctrDriverLicenseInfo();
            this.txtHead = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDetainId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLicenseId = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.gbxFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnAddUser);
            this.gbxFilter.Controls.Add(this.txtSearchLicense);
            this.gbxFilter.Controls.Add(this.label1);
            this.gbxFilter.Location = new System.Drawing.Point(12, 65);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(1064, 87);
            this.gbxFilter.TabIndex = 98;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            this.gbxFilter.Enter += new System.EventHandler(this.gbxFilter_Enter);
            // 
            // txtSearchLicense
            // 
            this.txtSearchLicense.Location = new System.Drawing.Point(191, 37);
            this.txtSearchLicense.Name = "txtSearchLicense";
            this.txtSearchLicense.Size = new System.Drawing.Size(230, 22);
            this.txtSearchLicense.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "License Id : ";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.btnAddUser.Location = new System.Drawing.Point(471, 21);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(60, 54);
            this.btnAddUser.TabIndex = 23;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrDriverLicenseInfo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 409);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License Info";
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.LicenseId = null;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(6, 21);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(1039, 364);
            this.ctrDriverLicenseInfo1.TabIndex = 0;
            // 
            // txtHead
            // 
            this.txtHead.AutoSize = true;
            this.txtHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHead.ForeColor = System.Drawing.Color.Firebrick;
            this.txtHead.Location = new System.Drawing.Point(414, 9);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(217, 32);
            this.txtHead.TabIndex = 105;
            this.txtHead.Text = "Detain License";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFineFees);
            this.groupBox2.Controls.Add(this.pictureBox18);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.lblLicenseId);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox15);
            this.groupBox2.Controls.Add(this.lblDetainDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblDetainId);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 583);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 160);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detain Info";
            // 
            // lblDetainId
            // 
            this.lblDetainId.AutoSize = true;
            this.lblDetainId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetainId.Location = new System.Drawing.Point(200, 18);
            this.lblDetainId.Name = "lblDetainId";
            this.lblDetainId.Size = new System.Drawing.Size(56, 25);
            this.lblDetainId.TabIndex = 115;
            this.lblDetainId.Text = "????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(162, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Detain Id :";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pictureBox15.Location = new System.Drawing.Point(162, 62);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(32, 32);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox15.TabIndex = 131;
            this.pictureBox15.TabStop = false;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetainDate.Location = new System.Drawing.Point(200, 63);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(56, 25);
            this.lblDetainDate.TabIndex = 130;
            this.lblDetainDate.Text = "????";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 25);
            this.label13.TabIndex = 129;
            this.label13.Text = "Detain Date :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(162, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 134;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 132;
            this.label4.Text = "Fine Fees :";
            // 
            // lblLicenseId
            // 
            this.lblLicenseId.AutoSize = true;
            this.lblLicenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLicenseId.Location = new System.Drawing.Point(661, 18);
            this.lblLicenseId.Name = "lblLicenseId";
            this.lblLicenseId.Size = new System.Drawing.Size(56, 25);
            this.lblLicenseId.TabIndex = 137;
            this.lblLicenseId.Text = "????";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(623, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 136;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 135;
            this.label3.Text = "License Id :";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox18.Location = new System.Drawing.Point(623, 63);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(32, 32);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox18.TabIndex = 140;
            this.pictureBox18.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreatedBy.Location = new System.Drawing.Point(661, 63);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedBy.TabIndex = 139;
            this.lblCreatedBy.Text = "????";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(466, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 25);
            this.label27.TabIndex = 138;
            this.label27.Text = "Created By : ";
            // 
            // btnDetain
            // 
            this.btnDetain.Enabled = false;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(949, 589);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(127, 51);
            this.btnDetain.TabIndex = 114;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserFrm.Image")));
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(808, 589);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(128, 51);
            this.btnCloseUserFrm.TabIndex = 113;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(843, 679);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(200, 25);
            this.linkLabel1.TabIndex = 111;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show License History";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(205, 112);
            this.txtFineFees.Multiline = true;
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(72, 31);
            this.txtFineFees.TabIndex = 141;
            this.txtFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineFees_KeyPress);
            // 
            // DetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 755);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxFilter);
            this.Name = "DetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetainLicense";
            this.Load += new System.EventHandler(this.DetainLicense_Load);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtSearchLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.Label txtHead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDetainId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLicenseId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}