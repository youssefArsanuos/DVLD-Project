namespace DVLD_Project
{
    partial class frmAddLocalLicense
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
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrPersonWithSearchBar1 = new DVLD_Project.ctrPersonWithSearchBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblUserCreat = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.btnPCClose = new System.Windows.Forms.Button();
            this.tabcontrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMainTitle.Location = new System.Drawing.Point(287, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(571, 38);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "New Local Driving License Application";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabPage1);
            this.tabcontrol1.Controls.Add(this.tabPage2);
            this.tabcontrol1.Location = new System.Drawing.Point(32, 50);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1081, 651);
            this.tabcontrol1.TabIndex = 2;
            
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ctrPersonWithSearchBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1073, 622);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD_Project.Properties.Resources.Next_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(948, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 39;
            this.button1.Text = "Next";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrPersonWithSearchBar1
            // 
            this.ctrPersonWithSearchBar1.Location = new System.Drawing.Point(17, 3);
            this.ctrPersonWithSearchBar1.Mode = 0;
            this.ctrPersonWithSearchBar1.Name = "ctrPersonWithSearchBar1";
            this.ctrPersonWithSearchBar1.PersonId = 0;
            this.ctrPersonWithSearchBar1.Size = new System.Drawing.Size(1053, 561);
            this.ctrPersonWithSearchBar1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.cmbLicenseClass);
            this.tabPage2.Controls.Add(this.lblUserCreat);
            this.tabPage2.Controls.Add(this.lblAppFees);
            this.tabPage2.Controls.Add(this.lblAppDate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLD_Project.Properties.Resources.Prev_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(949, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 48);
            this.button2.TabIndex = 44;
            this.button2.Text = "Prev";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbLicenseClass
            // 
            this.cmbLicenseClass.FormattingEnabled = true;
            this.cmbLicenseClass.Location = new System.Drawing.Point(355, 219);
            this.cmbLicenseClass.Name = "cmbLicenseClass";
            this.cmbLicenseClass.Size = new System.Drawing.Size(280, 24);
            this.cmbLicenseClass.TabIndex = 43;
            this.cmbLicenseClass.SelectedIndexChanged += new System.EventHandler(this.cmbLicenseClass_SelectedIndexChanged);
            // 
            // lblUserCreat
            // 
            this.lblUserCreat.AutoSize = true;
            this.lblUserCreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreat.Location = new System.Drawing.Point(350, 369);
            this.lblUserCreat.Name = "lblUserCreat";
            this.lblUserCreat.Size = new System.Drawing.Size(73, 29);
            this.lblUserCreat.TabIndex = 42;
            this.lblUserCreat.Text = "?????";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(350, 295);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(73, 29);
            this.lblAppFees.TabIndex = 41;
            this.lblAppFees.Text = "?????";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(350, 147);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(73, 29);
            this.lblAppDate.TabIndex = 40;
            this.lblAppDate.Text = "?????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Created By :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(286, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Application Fees :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(286, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "License Class :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.New_Driving_License_32;
            this.pictureBox1.Location = new System.Drawing.Point(286, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Application Date :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pictureBox3.Location = new System.Drawing.Point(286, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // btnPCSave
            // 
            this.btnPCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnPCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCSave.Location = new System.Drawing.Point(1000, 707);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(109, 48);
            this.btnPCSave.TabIndex = 39;
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
            this.btnPCClose.Location = new System.Drawing.Point(877, 707);
            this.btnPCClose.Name = "btnPCClose";
            this.btnPCClose.Size = new System.Drawing.Size(117, 48);
            this.btnPCClose.TabIndex = 38;
            this.btnPCClose.Text = "Close";
            this.btnPCClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCClose.UseVisualStyleBackColor = true;
            this.btnPCClose.Click += new System.EventHandler(this.btnPCClose_Click);
            // 
            // frmAddLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 765);
            this.Controls.Add(this.btnPCSave);
            this.Controls.Add(this.btnPCClose);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "frmAddLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLocalLicense";
            this.Load += new System.EventHandler(this.AddLocalLicense_Load);
            this.tabcontrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPCSave;
        private System.Windows.Forms.Button btnPCClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUserCreat;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cmbLicenseClass;
        private System.Windows.Forms.TabPage tabPage1;
        private ctrPersonWithSearchBar ctrPersonWithSearchBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}