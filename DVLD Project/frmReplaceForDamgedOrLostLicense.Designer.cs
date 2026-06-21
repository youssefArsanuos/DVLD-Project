namespace DVLD_Project
{
    partial class frmReplaceForDamgedOrLostLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceForDamgedOrLostLicense));
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtSearchLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHead = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrDriverLicenseInfo1 = new DVLD_Project.ctrDriverLicenseInfo();
            this.label27 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.lbloldLicenseId = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblReplaceLicense = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbApplicationId = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.gbxReplacementFor = new System.Windows.Forms.GroupBox();
            this.rdbLostLicense = new System.Windows.Forms.RadioButton();
            this.rdbDamgedLicense = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbxFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbxReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnAddUser);
            this.gbxFilter.Controls.Add(this.txtSearchLicense);
            this.gbxFilter.Controls.Add(this.label1);
            this.gbxFilter.Location = new System.Drawing.Point(21, 39);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(789, 87);
            this.gbxFilter.TabIndex = 105;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.btnAddUser.Location = new System.Drawing.Point(471, 25);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(60, 54);
            this.btnAddUser.TabIndex = 23;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtSearchLicense
            // 
            this.txtSearchLicense.Location = new System.Drawing.Point(191, 41);
            this.txtSearchLicense.Name = "txtSearchLicense";
            this.txtSearchLicense.Size = new System.Drawing.Size(230, 22);
            this.txtSearchLicense.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "License Id : ";
            // 
            // txtHead
            // 
            this.txtHead.AutoSize = true;
            this.txtHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHead.ForeColor = System.Drawing.Color.Firebrick;
            this.txtHead.Location = new System.Drawing.Point(324, 4);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(498, 32);
            this.txtHead.TabIndex = 104;
            this.txtHead.Text = "Replacement For Damaged License";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreatedBy.Location = new System.Drawing.Point(733, 122);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedBy.TabIndex = 104;
            this.lblCreatedBy.Text = "????";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrDriverLicenseInfo1);
            this.groupBox1.Location = new System.Drawing.Point(21, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 391);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License Info";
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.LicenseId = null;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(6, 39);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(1039, 364);
            this.ctrDriverLicenseInfo1.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(483, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 25);
            this.label27.TabIndex = 103;
            this.label27.Text = "Created By : ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Enabled = false;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(41, 736);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(216, 25);
            this.linkLabel2.TabIndex = 108;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show New License Info";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox13);
            this.groupBox2.Controls.Add(this.pictureBox18);
            this.groupBox2.Controls.Add(this.pictureBox19);
            this.groupBox2.Controls.Add(this.pictureBox21);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.lbloldLicenseId);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.lblReplaceLicense);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lblAppFees);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblApplicationDate);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbApplicationId);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(21, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 187);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(185, 38);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 127;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pictureBox13.Location = new System.Drawing.Point(185, 80);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(32, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 114;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox18.Location = new System.Drawing.Point(695, 122);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(32, 32);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox18.TabIndex = 110;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::DVLD_Project.Properties.Resources.LocalDriving_License;
            this.pictureBox19.Location = new System.Drawing.Point(695, 80);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(32, 32);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox19.TabIndex = 109;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_32;
            this.pictureBox21.Location = new System.Drawing.Point(695, 34);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(32, 32);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox21.TabIndex = 105;
            this.pictureBox21.TabStop = false;
            // 
            // lbloldLicenseId
            // 
            this.lbloldLicenseId.AutoSize = true;
            this.lbloldLicenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbloldLicenseId.Location = new System.Drawing.Point(733, 76);
            this.lbloldLicenseId.Name = "lbloldLicenseId";
            this.lbloldLicenseId.Size = new System.Drawing.Size(56, 25);
            this.lbloldLicenseId.TabIndex = 102;
            this.lbloldLicenseId.Text = "????";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(483, 76);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(148, 25);
            this.label29.TabIndex = 101;
            this.label29.Text = "Old License Id :";
            // 
            // lblReplaceLicense
            // 
            this.lblReplaceLicense.AutoSize = true;
            this.lblReplaceLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReplaceLicense.Location = new System.Drawing.Point(733, 34);
            this.lblReplaceLicense.Name = "lblReplaceLicense";
            this.lblReplaceLicense.Size = new System.Drawing.Size(56, 25);
            this.lblReplaceLicense.TabIndex = 100;
            this.lblReplaceLicense.Text = "????";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(483, 34);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(199, 25);
            this.label31.TabIndex = 99;
            this.label31.Text = "Replaced License Id :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(185, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAppFees.Location = new System.Drawing.Point(223, 123);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(56, 25);
            this.lblAppFees.TabIndex = 92;
            this.lblAppFees.Text = "????";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 25);
            this.label14.TabIndex = 91;
            this.label14.Text = "Application Fees :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblApplicationDate.Location = new System.Drawing.Point(223, 80);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(56, 25);
            this.lblApplicationDate.TabIndex = 90;
            this.lblApplicationDate.Text = "????";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 25);
            this.label18.TabIndex = 89;
            this.label18.Text = "Appliation Date :";
            // 
            // lbApplicationId
            // 
            this.lbApplicationId.AutoSize = true;
            this.lbApplicationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbApplicationId.Location = new System.Drawing.Point(223, 38);
            this.lbApplicationId.Name = "lbApplicationId";
            this.lbApplicationId.Size = new System.Drawing.Size(56, 25);
            this.lbApplicationId.TabIndex = 88;
            this.lbApplicationId.Text = "????";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(17, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(169, 25);
            this.label22.TabIndex = 87;
            this.label22.Text = "L.RApplicationId : ";
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(716, 730);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(127, 51);
            this.btnIssue.TabIndex = 110;
            this.btnIssue.Text = "Renew";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserFrm.Image")));
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(575, 730);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(128, 51);
            this.btnCloseUserFrm.TabIndex = 109;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // gbxReplacementFor
            // 
            this.gbxReplacementFor.Controls.Add(this.rdbLostLicense);
            this.gbxReplacementFor.Controls.Add(this.rdbDamgedLicense);
            this.gbxReplacementFor.Location = new System.Drawing.Point(829, 39);
            this.gbxReplacementFor.Name = "gbxReplacementFor";
            this.gbxReplacementFor.Size = new System.Drawing.Size(263, 88);
            this.gbxReplacementFor.TabIndex = 111;
            this.gbxReplacementFor.TabStop = false;
            this.gbxReplacementFor.Text = "Replacement For";
            // 
            // rdbLostLicense
            // 
            this.rdbLostLicense.AutoSize = true;
            this.rdbLostLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rdbLostLicense.Location = new System.Drawing.Point(44, 59);
            this.rdbLostLicense.Name = "rdbLostLicense";
            this.rdbLostLicense.Size = new System.Drawing.Size(127, 24);
            this.rdbLostLicense.TabIndex = 1;
            this.rdbLostLicense.Text = "Lost License";
            this.rdbLostLicense.UseVisualStyleBackColor = true;
            this.rdbLostLicense.CheckedChanged += new System.EventHandler(this.rdbLostLicense_CheckedChanged);
            // 
            // rdbDamgedLicense
            // 
            this.rdbDamgedLicense.AutoSize = true;
            this.rdbDamgedLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDamgedLicense.Location = new System.Drawing.Point(44, 25);
            this.rdbDamgedLicense.Name = "rdbDamgedLicense";
            this.rdbDamgedLicense.Size = new System.Drawing.Size(157, 24);
            this.rdbDamgedLicense.TabIndex = 0;
            this.rdbDamgedLicense.Text = "Damged License";
            this.rdbDamgedLicense.UseVisualStyleBackColor = true;
            this.rdbDamgedLicense.CheckedChanged += new System.EventHandler(this.rdbDamgedLicense_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(307, 736);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(210, 25);
            this.linkLabel1.TabIndex = 112;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show Licences History";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // frmReplaceForDamgedOrLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 796);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gbxReplacementFor);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmReplaceForDamgedOrLostLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace For Damged Or Lost License";
            this.Load += new System.EventHandler(this.frmReplaceForDamgedOrLostLicense_Load);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbxReplacementFor.ResumeLayout(false);
            this.gbxReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtSearchLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label txtHead;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbloldLicenseId;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblReplaceLicense;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbApplicationId;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox gbxReplacementFor;
        private System.Windows.Forms.RadioButton rdbLostLicense;
        private System.Windows.Forms.RadioButton rdbDamgedLicense;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}