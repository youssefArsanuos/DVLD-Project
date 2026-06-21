namespace DVLD_Project
{
    partial class frmChangeUserPassword
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
            this.ctrUserrCard1 = new DVLD_Project.ctrUserrCard();
            this.txtUserOldPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPCClose = new System.Windows.Forms.Button();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrUserrCard1
            // 
            this.ctrUserrCard1.IsActive = ((byte)(0));
            this.ctrUserrCard1.Location = new System.Drawing.Point(12, 2);
            this.ctrUserrCard1.Mode = 0;
            this.ctrUserrCard1.Name = "ctrUserrCard1";
            this.ctrUserrCard1.PersonId = 0;
            this.ctrUserrCard1.Size = new System.Drawing.Size(1042, 601);
            this.ctrUserrCard1.TabIndex = 0;
            this.ctrUserrCard1.UserId = 0;
            this.ctrUserrCard1.UserName = null;
            // 
            // txtUserOldPass
            // 
            this.txtUserOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserOldPass.Location = new System.Drawing.Point(253, 673);
            this.txtUserOldPass.Multiline = true;
            this.txtUserOldPass.Name = "txtUserOldPass";
            this.txtUserOldPass.PasswordChar = '*';
            this.txtUserOldPass.Size = new System.Drawing.Size(156, 28);
            this.txtUserOldPass.TabIndex = 29;
            this.txtUserOldPass.TextChanged += new System.EventHandler(this.txtUserOldPass_TextChanged);
            this.txtUserOldPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserOldPass_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(193, 673);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 676);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Old Password : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(741, 626);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(156, 28);
            this.txtNewPassword.TabIndex = 32;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(681, 626);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "New Password : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConNewPassword
            // 
            this.txtConNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNewPassword.Location = new System.Drawing.Point(741, 708);
            this.txtConNewPassword.Multiline = true;
            this.txtConNewPassword.Name = "txtConNewPassword";
            this.txtConNewPassword.PasswordChar = '*';
            this.txtConNewPassword.Size = new System.Drawing.Size(156, 28);
            this.txtConNewPassword.TabIndex = 35;
            this.txtConNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConNewPassword_Validating);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(681, 708);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 711);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Confirm New Password : ";
            // 
            // btnPCClose
            // 
            this.btnPCClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnPCClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCClose.Location = new System.Drawing.Point(922, 688);
            this.btnPCClose.Name = "btnPCClose";
            this.btnPCClose.Size = new System.Drawing.Size(109, 48);
            this.btnPCClose.TabIndex = 36;
            this.btnPCClose.Text = "Close";
            this.btnPCClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCClose.UseVisualStyleBackColor = true;
            this.btnPCClose.Click += new System.EventHandler(this.btnPCClose_Click);
            // 
            // btnPCSave
            // 
            this.btnPCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnPCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCSave.Location = new System.Drawing.Point(922, 626);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(109, 48);
            this.btnPCSave.TabIndex = 38;
            this.btnPCSave.Text = "Save";
            this.btnPCSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCSave.UseVisualStyleBackColor = true;
            this.btnPCSave.Click += new System.EventHandler(this.btnPCSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 768);
            this.Controls.Add(this.btnPCSave);
            this.Controls.Add(this.btnPCClose);
            this.Controls.Add(this.txtConNewPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserOldPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrUserrCard1);
            this.Name = "frmChangeUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeUserPassword";
            this.Load += new System.EventHandler(this.ChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrUserrCard ctrUserrCard1;
        private System.Windows.Forms.TextBox txtUserOldPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConNewPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPCClose;
        private System.Windows.Forms.Button btnPCSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}