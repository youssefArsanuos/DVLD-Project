namespace DVLD_Project
{
    partial class frmShowLicenseHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecor = new System.Windows.Forms.Label();
            this.dvgLocalLicenses = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecords2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dvgInternationalLiceses = new System.Windows.Forms.DataGridView();
            this.btnClosePeopleFrm = new System.Windows.Forms.Button();
            this.ctrPerson1 = new DVLD_Project.ctrPerson();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLocalLicenses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInternationalLiceses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "license History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 170);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(26, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1199, 326);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblRecords);
            this.tabPage1.Controls.Add(this.lblRecor);
            this.tabPage1.Controls.Add(this.dvgLocalLicenses);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.Local_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Local Licenses History :";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(140, 231);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 29);
            this.lblRecords.TabIndex = 43;
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(6, 231);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(122, 25);
            this.lblRecor.TabIndex = 42;
            this.lblRecor.Text = "#Records : ";
            this.lblRecor.Click += new System.EventHandler(this.lblRecor_Click);
            // 
            // dvgLocalLicenses
            // 
            this.dvgLocalLicenses.AllowUserToAddRows = false;
            this.dvgLocalLicenses.AllowUserToDeleteRows = false;
            this.dvgLocalLicenses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLocalLicenses.Location = new System.Drawing.Point(6, 56);
            this.dvgLocalLicenses.Name = "dvgLocalLicenses";
            this.dvgLocalLicenses.ReadOnly = true;
            this.dvgLocalLicenses.RowHeadersWidth = 51;
            this.dvgLocalLicenses.RowTemplate.Height = 24;
            this.dvgLocalLicenses.Size = new System.Drawing.Size(1158, 160);
            this.dvgLocalLicenses.TabIndex = 41;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblRecords2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dvgInternationalLiceses);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1170, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "InterNational";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Local Licenses History :";
            // 
            // lblRecords2
            // 
            this.lblRecords2.AutoSize = true;
            this.lblRecords2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords2.Location = new System.Drawing.Point(140, 232);
            this.lblRecords2.Name = "lblRecords2";
            this.lblRecords2.Size = new System.Drawing.Size(0, 29);
            this.lblRecords2.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "#Records : ";
            // 
            // dvgInternationalLiceses
            // 
            this.dvgInternationalLiceses.AllowUserToAddRows = false;
            this.dvgInternationalLiceses.AllowUserToDeleteRows = false;
            this.dvgInternationalLiceses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgInternationalLiceses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInternationalLiceses.Location = new System.Drawing.Point(6, 52);
            this.dvgInternationalLiceses.Name = "dvgInternationalLiceses";
            this.dvgInternationalLiceses.ReadOnly = true;
            this.dvgInternationalLiceses.RowHeadersWidth = 51;
            this.dvgInternationalLiceses.RowTemplate.Height = 24;
            this.dvgInternationalLiceses.Size = new System.Drawing.Size(1158, 150);
            this.dvgInternationalLiceses.TabIndex = 45;
            // 
            // btnClosePeopleFrm
            // 
            this.btnClosePeopleFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePeopleFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClosePeopleFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePeopleFrm.Location = new System.Drawing.Point(1078, 812);
            this.btnClosePeopleFrm.Name = "btnClosePeopleFrm";
            this.btnClosePeopleFrm.Size = new System.Drawing.Size(147, 48);
            this.btnClosePeopleFrm.TabIndex = 89;
            this.btnClosePeopleFrm.Text = "Close";
            this.btnClosePeopleFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClosePeopleFrm.UseVisualStyleBackColor = true;
            this.btnClosePeopleFrm.Click += new System.EventHandler(this.btnClosePeopleFrm_Click);
            // 
            // ctrPerson1
            // 
            this.ctrPerson1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrPerson1.Location = new System.Drawing.Point(208, 12);
            this.ctrPerson1.Mode = 0;
            this.ctrPerson1.Name = "ctrPerson1";
            this.ctrPerson1.PersonId = 0;
            this.ctrPerson1.Size = new System.Drawing.Size(1011, 462);
            this.ctrPerson1.TabIndex = 26;
            // 
            // frmShowLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 868);
            this.Controls.Add(this.btnClosePeopleFrm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrPerson1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show License History";
            this.Load += new System.EventHandler(this.frmShowLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLocalLicenses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInternationalLiceses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrPerson ctrPerson1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClosePeopleFrm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecor;
        private System.Windows.Forms.DataGridView dvgLocalLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecords2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dvgInternationalLiceses;
    }
}