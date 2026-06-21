namespace DVLD_Project
{
    partial class AddandDelete_Person
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.ctrPerson1 = new DVLD_Project.ctrPerson();
            this.lblPersonIdTex = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.Red;
            this.lblMainTitle.Location = new System.Drawing.Point(433, 28);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(0, 38);
            this.lblMainTitle.TabIndex = 1;
            // 
            // ctrPerson1
            // 
            this.ctrPerson1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrPerson1.Location = new System.Drawing.Point(25, 107);
            this.ctrPerson1.Mode = 0;
            this.ctrPerson1.Name = "ctrPerson1";
            this.ctrPerson1.PersonId = 0;
            this.ctrPerson1.Size = new System.Drawing.Size(1029, 515);
            this.ctrPerson1.TabIndex = 0;
            this.ctrPerson1.Load += new System.EventHandler(this.ctrPerson1_Load);
            // 
            // lblPersonIdTex
            // 
            this.lblPersonIdTex.AutoSize = true;
            this.lblPersonIdTex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIdTex.Location = new System.Drawing.Point(54, 634);
            this.lblPersonIdTex.Name = "lblPersonIdTex";
            this.lblPersonIdTex.Size = new System.Drawing.Size(106, 25);
            this.lblPersonIdTex.TabIndex = 2;
            this.lblPersonIdTex.Text = "Person Id :";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.Location = new System.Drawing.Point(176, 634);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(0, 25);
            this.lblPersonId.TabIndex = 3;
            // 
            // AddandDelete_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 680);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.lblPersonIdTex);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.ctrPerson1);
            this.Name = "AddandDelete_Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPerson ctrPerson1;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblPersonIdTex;
        private System.Windows.Forms.Label lblPersonId;
    }
}