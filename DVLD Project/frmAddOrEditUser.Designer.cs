namespace DVLD_Project
{
    partial class frmAddOrEditUser
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtUSearchPerson = new System.Windows.Forms.TextBox();
            this.cmbUSearchPeoples = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrPerson1 = new DVLD_Project.ctrPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUserCPass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.btnPCClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMainTitle.Location = new System.Drawing.Point(450, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(229, 38);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 661);
            this.tabControl1.TabIndex = 1;
          
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ctrPerson1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1098, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchPerson);
            this.groupBox1.Controls.Add(this.btnAddPerson);
            this.groupBox1.Controls.Add(this.txtUSearchPerson);
            this.groupBox1.Controls.Add(this.cmbUSearchPeoples);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 94);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Image = global::DVLD_Project.Properties.Resources.SearchPerson;
            this.btnSearchPerson.Location = new System.Drawing.Point(591, 36);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(48, 47);
            this.btnSearchPerson.TabIndex = 39;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD_Project.Properties.Resources.AddPerson_32;
            this.btnAddPerson.Location = new System.Drawing.Point(645, 36);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(49, 47);
            this.btnAddPerson.TabIndex = 38;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtUSearchPerson
            // 
            this.txtUSearchPerson.Location = new System.Drawing.Point(351, 48);
            this.txtUSearchPerson.Name = "txtUSearchPerson";
            this.txtUSearchPerson.Size = new System.Drawing.Size(234, 22);
            this.txtUSearchPerson.TabIndex = 10;
            this.txtUSearchPerson.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUSearchPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUSearchPerson_KeyPress);
            // 
            // cmbUSearchPeoples
            // 
            this.cmbUSearchPeoples.FormattingEnabled = true;
            this.cmbUSearchPeoples.Location = new System.Drawing.Point(144, 46);
            this.cmbUSearchPeoples.Name = "cmbUSearchPeoples";
            this.cmbUSearchPeoples.Size = new System.Drawing.Size(201, 24);
            this.cmbUSearchPeoples.TabIndex = 9;
            this.cmbUSearchPeoples.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter By : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD_Project.Properties.Resources.Next_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(983, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 48);
            this.button1.TabIndex = 38;
            this.button1.Text = "Next";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrPerson1
            // 
            this.ctrPerson1.Location = new System.Drawing.Point(29, 113);
            this.ctrPerson1.Mode = 0;
            this.ctrPerson1.Name = "ctrPerson1";
            this.ctrPerson1.PersonId = 0;
            this.ctrPerson1.Size = new System.Drawing.Size(1037, 459);
            this.ctrPerson1.TabIndex = 0;
            this.ctrPerson1.Load += new System.EventHandler(this.ctrPerson1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUserCPass);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.chkIsActive);
            this.tabPage2.Controls.Add(this.txtUserName);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtUserPass);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1098, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtUserCPass
            // 
            this.txtUserCPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserCPass.Location = new System.Drawing.Point(284, 367);
            this.txtUserCPass.Multiline = true;
            this.txtUserCPass.Name = "txtUserCPass";
            this.txtUserCPass.PasswordChar = '*';
            this.txtUserCPass.Size = new System.Drawing.Size(156, 28);
            this.txtUserCPass.TabIndex = 27;
            this.txtUserCPass.TextChanged += new System.EventHandler(this.txtUserCPas_TextChanged);
            this.txtUserCPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserCPas_Validating);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLD_Project.Properties.Resources.Prev_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(983, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 48);
            this.button2.TabIndex = 39;
            this.button2.Text = "Prev";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(610, 255);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(124, 29);
            this.chkIsActive.TabIndex = 28;
            this.chkIsActive.Text = "Is Active ?";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(284, 160);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 28);
            this.txtUserName.TabIndex = 25;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.Person_32;
            this.pictureBox3.Location = new System.Drawing.Point(224, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Name :";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(284, 255);
            this.txtUserPass.Multiline = true;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(156, 28);
            this.txtUserPass.TabIndex = 26;
            this.txtUserPass.TextChanged += new System.EventHandler(this.txtUserPass_TextChanged);
            this.txtUserPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserPass_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(224, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(224, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Confirm Password : ";
            // 
            // btnPCSave
            // 
            this.btnPCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnPCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCSave.Location = new System.Drawing.Point(1009, 714);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(109, 48);
            this.btnPCSave.TabIndex = 37;
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
            this.btnPCClose.Location = new System.Drawing.Point(886, 714);
            this.btnPCClose.Name = "btnPCClose";
            this.btnPCClose.Size = new System.Drawing.Size(117, 48);
            this.btnPCClose.TabIndex = 36;
            this.btnPCClose.Text = "Close";
            this.btnPCClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCClose.UseVisualStyleBackColor = true;
            this.btnPCClose.Click += new System.EventHandler(this.btnPCClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 771);
            this.Controls.Add(this.btnPCSave);
            this.Controls.Add(this.btnPCClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "frmAddOrEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ctrPerson ctrPerson1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPCSave;
        private System.Windows.Forms.Button btnPCClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUSearchPerson;
        private System.Windows.Forms.ComboBox cmbUSearchPeoples;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtUserCPass;
    }
}