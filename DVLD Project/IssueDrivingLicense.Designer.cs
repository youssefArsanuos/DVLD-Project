namespace DVLD_Project
{
    partial class IssueDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueDrivingLicense));
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.txtTestNotes = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.ctrLicenseApplicationInfo1 = new DVLD_Project.ctrLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserFrm.Image")));
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(650, 606);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(128, 42);
            this.btnCloseUserFrm.TabIndex = 33;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // txtTestNotes
            // 
            this.txtTestNotes.Location = new System.Drawing.Point(131, 439);
            this.txtTestNotes.Multiline = true;
            this.txtTestNotes.Name = "txtTestNotes";
            this.txtTestNotes.Size = new System.Drawing.Size(799, 149);
            this.txtTestNotes.TabIndex = 60;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD_Project.Properties.Resources.Notes_32;
            this.pictureBox11.Location = new System.Drawing.Point(79, 432);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 59;
            this.pictureBox11.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Notes :";
            // 
            // btnPCSave
            // 
            this.btnPCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCSave.Image = global::DVLD_Project.Properties.Resources.IssueDrivingLicense_32;
            this.btnPCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCSave.Location = new System.Drawing.Point(803, 606);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(127, 42);
            this.btnPCSave.TabIndex = 61;
            this.btnPCSave.Text = "Issue";
            this.btnPCSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCSave.UseVisualStyleBackColor = true;
            this.btnPCSave.Click += new System.EventHandler(this.btnPCSave_Click);
            // 
            // ctrLicenseApplicationInfo1
            // 
            this.ctrLicenseApplicationInfo1.ApplicationId = 0;
            this.ctrLicenseApplicationInfo1.LDLAId = null;
            this.ctrLicenseApplicationInfo1.LicenseClassId = 0;
            this.ctrLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrLicenseApplicationInfo1.Name = "ctrLicenseApplicationInfo1";
            this.ctrLicenseApplicationInfo1.PersonId = 0;
            this.ctrLicenseApplicationInfo1.Size = new System.Drawing.Size(932, 421);
            this.ctrLicenseApplicationInfo1.TabIndex = 32;
            this.ctrLicenseApplicationInfo1.UserId = 0;
            this.ctrLicenseApplicationInfo1.Load += new System.EventHandler(this.ctrLicenseApplicationInfo1_Load);
            // 
            // IssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 671);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.btnPCSave);
            this.Controls.Add(this.txtTestNotes);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrLicenseApplicationInfo1);
            this.Name = "IssueDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueDrivingLicense";
            this.Load += new System.EventHandler(this.IssueDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseUserFrm;
        private ctrLicenseApplicationInfo ctrLicenseApplicationInfo1;
        private System.Windows.Forms.TextBox txtTestNotes;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPCSave;
    }
}