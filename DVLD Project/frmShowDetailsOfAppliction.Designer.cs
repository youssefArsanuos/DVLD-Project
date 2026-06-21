namespace DVLD_Project
{
    partial class frmShowDetailsOfAppliction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDetailsOfAppliction));
            this.ctrLicenseApplicationInfo1 = new DVLD_Project.ctrLicenseApplicationInfo();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.ctrLicenseApplicationInfo1.TabIndex = 1;
            this.ctrLicenseApplicationInfo1.UserId = 0;
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserFrm.Image")));
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(790, 439);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 31;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // frmShowDetailsOfAppliction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 509);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.ctrLicenseApplicationInfo1);
            this.Name = "frmShowDetailsOfAppliction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Details Of Appliction";
            this.Load += new System.EventHandler(this.frmShowDetailsOfAppliction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrLicenseApplicationInfo ctrLicenseApplicationInfo1;
        private System.Windows.Forms.Button btnCloseUserFrm;
    }
}