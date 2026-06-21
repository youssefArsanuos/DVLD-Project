namespace DVLD_Project
{
    partial class frmIssueInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueInternationalLicense));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrDriverLicenseInfo1 = new DVLD_Project.ctrDriverLicenseInfo();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtSearchLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.lblAppExipirationDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblLocalLicenseId = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblInterLicense = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblIssueAppDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbApplicationId = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrDriverLicenseInfo1);
            this.groupBox1.Location = new System.Drawing.Point(30, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 391);
            this.groupBox1.TabIndex = 86;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(345, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(435, 32);
            this.label6.TabIndex = 88;
            this.label6.Text = "Internation License Application";
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnAddUser);
            this.gbxFilter.Controls.Add(this.txtSearchLicense);
            this.gbxFilter.Controls.Add(this.label1);
            this.gbxFilter.Location = new System.Drawing.Point(30, 44);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(1071, 87);
            this.gbxFilter.TabIndex = 89;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox16);
            this.groupBox2.Controls.Add(this.pictureBox13);
            this.groupBox2.Controls.Add(this.pictureBox20);
            this.groupBox2.Controls.Add(this.lblAppExipirationDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pictureBox18);
            this.groupBox2.Controls.Add(this.pictureBox19);
            this.groupBox2.Controls.Add(this.pictureBox21);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.lblLocalLicenseId);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.lblInterLicense);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lblIssueAppDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox17);
            this.groupBox2.Controls.Add(this.lblFees);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblApplicationDate);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbApplicationId);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(30, 534);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 195);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pictureBox16.Location = new System.Drawing.Point(185, 107);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(32, 32);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox16.TabIndex = 115;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pictureBox13.Location = new System.Drawing.Point(185, 62);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(32, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 114;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pictureBox20.Location = new System.Drawing.Point(654, 105);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(32, 32);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox20.TabIndex = 113;
            this.pictureBox20.TabStop = false;
            // 
            // lblAppExipirationDate
            // 
            this.lblAppExipirationDate.AutoSize = true;
            this.lblAppExipirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAppExipirationDate.Location = new System.Drawing.Point(693, 103);
            this.lblAppExipirationDate.Name = "lblAppExipirationDate";
            this.lblAppExipirationDate.Size = new System.Drawing.Size(56, 25);
            this.lblAppExipirationDate.TabIndex = 112;
            this.lblAppExipirationDate.Text = "????";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(483, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 111;
            this.label10.Text = "Expiration Date :";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox18.Location = new System.Drawing.Point(654, 147);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(32, 32);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox18.TabIndex = 110;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::DVLD_Project.Properties.Resources.LocalDriving_License;
            this.pictureBox19.Location = new System.Drawing.Point(654, 62);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(32, 32);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox19.TabIndex = 109;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.pictureBox21.Location = new System.Drawing.Point(654, 16);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(32, 32);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox21.TabIndex = 105;
            this.pictureBox21.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreatedBy.Location = new System.Drawing.Point(692, 147);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedBy.TabIndex = 104;
            this.lblCreatedBy.Text = "????";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(483, 147);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 25);
            this.label27.TabIndex = 103;
            this.label27.Text = "Created By : ";
            // 
            // lblLocalLicenseId
            // 
            this.lblLocalLicenseId.AutoSize = true;
            this.lblLocalLicenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocalLicenseId.Location = new System.Drawing.Point(692, 58);
            this.lblLocalLicenseId.Name = "lblLocalLicenseId";
            this.lblLocalLicenseId.Size = new System.Drawing.Size(56, 25);
            this.lblLocalLicenseId.TabIndex = 102;
            this.lblLocalLicenseId.Text = "????";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(483, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(164, 25);
            this.label29.TabIndex = 101;
            this.label29.Text = "Local License Id :";
            // 
            // lblInterLicense
            // 
            this.lblInterLicense.AutoSize = true;
            this.lblInterLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInterLicense.Location = new System.Drawing.Point(692, 16);
            this.lblInterLicense.Name = "lblInterLicense";
            this.lblInterLicense.Size = new System.Drawing.Size(56, 25);
            this.lblInterLicense.TabIndex = 100;
            this.lblInterLicense.Text = "????";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(483, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(133, 25);
            this.label31.TabIndex = 99;
            this.label31.Text = "I.LLicense Id :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(185, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // lblIssueAppDate
            // 
            this.lblIssueAppDate.AutoSize = true;
            this.lblIssueAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIssueAppDate.Location = new System.Drawing.Point(223, 107);
            this.lblIssueAppDate.Name = "lblIssueAppDate";
            this.lblIssueAppDate.Size = new System.Drawing.Size(56, 25);
            this.lblIssueAppDate.TabIndex = 96;
            this.lblIssueAppDate.Text = "????";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 94;
            this.label8.Text = "Issue Date : ";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.pictureBox17.Location = new System.Drawing.Point(185, 20);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(32, 32);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox17.TabIndex = 93;
            this.pictureBox17.TabStop = false;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFees.Location = new System.Drawing.Point(223, 151);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(56, 25);
            this.lblFees.TabIndex = 92;
            this.lblFees.Text = "????";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 25);
            this.label14.TabIndex = 91;
            this.label14.Text = "Fees :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblApplicationDate.Location = new System.Drawing.Point(223, 62);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(56, 25);
            this.lblApplicationDate.TabIndex = 90;
            this.lblApplicationDate.Text = "????";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 25);
            this.label18.TabIndex = 89;
            this.label18.Text = "Appliation Date :";
            // 
            // lbApplicationId
            // 
            this.lbApplicationId.AutoSize = true;
            this.lbApplicationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbApplicationId.Location = new System.Drawing.Point(223, 20);
            this.lbApplicationId.Name = "lbApplicationId";
            this.lbApplicationId.Size = new System.Drawing.Size(56, 25);
            this.lbApplicationId.TabIndex = 88;
            this.lbApplicationId.Text = "????";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(23, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(161, 25);
            this.label22.TabIndex = 87;
            this.label22.Text = "I.LApplicationId : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(25, 752);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(200, 25);
            this.linkLabel1.TabIndex = 91;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show License History";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Enabled = false;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(248, 752);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(172, 25);
            this.linkLabel2.TabIndex = 92;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show License Info";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserFrm.Image")));
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(801, 740);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(128, 51);
            this.btnCloseUserFrm.TabIndex = 93;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(954, 740);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(127, 51);
            this.btnIssue.TabIndex = 94;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // frmIssueInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 805);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIssueInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue International License";
            this.Load += new System.EventHandler(this.frmIssueInternationalLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.TextBox txtSearchLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblIssueAppDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbApplicationId;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblLocalLicenseId;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblInterLicense;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label lblAppExipirationDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.Button btnIssue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
    }
}