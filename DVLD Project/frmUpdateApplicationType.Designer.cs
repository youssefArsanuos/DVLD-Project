namespace DVLD_Project
{
    partial class frmUpdateApplicationType
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.txtAppTitle = new System.Windows.Forms.TextBox();
            this.txtAppFees = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.btnPCClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Application Types";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(80, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Fees :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(56, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Title :";
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblApplicationId.Location = new System.Drawing.Point(174, 112);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(0, 25);
            this.lblApplicationId.TabIndex = 44;
            // 
            // txtAppTitle
            // 
            this.txtAppTitle.Location = new System.Drawing.Point(188, 193);
            this.txtAppTitle.Name = "txtAppTitle";
            this.txtAppTitle.Size = new System.Drawing.Size(250, 22);
            this.txtAppTitle.TabIndex = 47;
            // 
            // txtAppFees
            // 
            this.txtAppFees.Location = new System.Drawing.Point(188, 269);
            this.txtAppFees.Name = "txtAppFees";
            this.txtAppFees.Size = new System.Drawing.Size(250, 22);
            this.txtAppFees.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox1.Location = new System.Drawing.Point(129, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_Project.Properties.Resources.ApplicationTitle;
            this.pictureBox8.Location = new System.Drawing.Point(129, 189);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 45;
            this.pictureBox8.TabStop = false;
            // 
            // btnPCSave
            // 
            this.btnPCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnPCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCSave.Location = new System.Drawing.Point(346, 352);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(126, 40);
            this.btnPCSave.TabIndex = 40;
            this.btnPCSave.Text = "Save";
            this.btnPCSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCSave.UseVisualStyleBackColor = true;
            this.btnPCSave.Click += new System.EventHandler(this.btnPCSave_Click);
            // 
            // btnPCClose
            // 
            this.btnPCClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnPCClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCClose.Location = new System.Drawing.Point(214, 352);
            this.btnPCClose.Name = "btnPCClose";
            this.btnPCClose.Size = new System.Drawing.Size(126, 40);
            this.btnPCClose.TabIndex = 39;
            this.btnPCClose.Text = "Close";
            this.btnPCClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCClose.UseVisualStyleBackColor = true;
            this.btnPCClose.Click += new System.EventHandler(this.btnPCClose_Click);
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 422);
            this.Controls.Add(this.txtAppFees);
            this.Controls.Add(this.txtAppTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.lblApplicationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPCSave);
            this.Controls.Add(this.btnPCClose);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Application Type";
            this.Load += new System.EventHandler(this.frmUpdateApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPCSave;
        private System.Windows.Forms.Button btnPCClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAppTitle;
        private System.Windows.Forms.TextBox txtAppFees;
    }
}