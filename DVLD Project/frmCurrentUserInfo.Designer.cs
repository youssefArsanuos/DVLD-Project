namespace DVLD_Project
{
    partial class frmCurrentUserInfo
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
            this.ctrUserrCard1 = new DVLD_Project.ctrUserrCard();
            this.btnPCClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrUserrCard1
            // 
            this.ctrUserrCard1.IsActive = ((byte)(0));
            this.ctrUserrCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrUserrCard1.Mode = 0;
            this.ctrUserrCard1.Name = "ctrUserrCard1";
            this.ctrUserrCard1.PersonId = 0;
            this.ctrUserrCard1.Size = new System.Drawing.Size(1042, 609);
            this.ctrUserrCard1.TabIndex = 0;
            this.ctrUserrCard1.UserId = 0;
            this.ctrUserrCard1.UserName = null;
            this.ctrUserrCard1.Load += new System.EventHandler(this.ctrUserrCard1_Load_1);
            // 
            // btnPCClose
            // 
            this.btnPCClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnPCClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCClose.Location = new System.Drawing.Point(913, 529);
            this.btnPCClose.Name = "btnPCClose";
            this.btnPCClose.Size = new System.Drawing.Size(117, 48);
            this.btnPCClose.TabIndex = 35;
            this.btnPCClose.Text = "Close";
            this.btnPCClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCClose.UseVisualStyleBackColor = true;
            this.btnPCClose.Click += new System.EventHandler(this.btnPCClose_Click);
            // 
            // frmCurrentUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 600);
            this.Controls.Add(this.btnPCClose);
            this.Controls.Add(this.ctrUserrCard1);
            this.Name = "frmCurrentUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current User Info";
            this.Load += new System.EventHandler(this.frmCurrentUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrUserrCard ctrUserrCard1;
        private System.Windows.Forms.Button btnPCClose;
    }
}