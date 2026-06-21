namespace DVLD_Project
{
    partial class frmShowDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDetainedLicense));
            this.txtSearchDrivers = new System.Windows.Forms.TextBox();
            this.cmbSearchDrivers = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecor = new System.Windows.Forms.Label();
            this.dvgDetainedLicense = new System.Windows.Forms.DataGridView();
            this.cntxDetainedLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxPDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetainedLicense)).BeginInit();
            this.cntxDetainedLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchDrivers
            // 
            this.txtSearchDrivers.Location = new System.Drawing.Point(354, 247);
            this.txtSearchDrivers.Multiline = true;
            this.txtSearchDrivers.Name = "txtSearchDrivers";
            this.txtSearchDrivers.Size = new System.Drawing.Size(191, 24);
            this.txtSearchDrivers.TabIndex = 51;
            this.txtSearchDrivers.TextChanged += new System.EventHandler(this.txtSearchDrivers_TextChanged);
            // 
            // cmbSearchDrivers
            // 
            this.cmbSearchDrivers.FormattingEnabled = true;
            this.cmbSearchDrivers.Location = new System.Drawing.Point(155, 247);
            this.cmbSearchDrivers.Name = "cmbSearchDrivers";
            this.cmbSearchDrivers.Size = new System.Drawing.Size(184, 24);
            this.cmbSearchDrivers.TabIndex = 50;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(161, 684);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 29);
            this.lblRecords.TabIndex = 49;
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(18, 684);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 48;
            this.lblRecor.Text = "#Records : ";
            // 
            // dvgDetainedLicense
            // 
            this.dvgDetainedLicense.AllowUserToAddRows = false;
            this.dvgDetainedLicense.AllowUserToDeleteRows = false;
            this.dvgDetainedLicense.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgDetainedLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetainedLicense.ContextMenuStrip = this.cntxDetainedLicense;
            this.dvgDetainedLicense.Location = new System.Drawing.Point(23, 299);
            this.dvgDetainedLicense.Name = "dvgDetainedLicense";
            this.dvgDetainedLicense.ReadOnly = true;
            this.dvgDetainedLicense.RowHeadersWidth = 51;
            this.dvgDetainedLicense.RowTemplate.Height = 24;
            this.dvgDetainedLicense.Size = new System.Drawing.Size(1238, 371);
            this.dvgDetainedLicense.TabIndex = 46;
            this.dvgDetainedLicense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDetainedLicense_CellContentClick);
            this.dvgDetainedLicense.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgDetainedLicense_MouseDown);
            // 
            // cntxDetainedLicense
            // 
            this.cntxDetainedLicense.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxDetainedLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.cntxPDelete});
            this.cntxDetainedLicense.Name = "cntxPeoples";
            this.cntxDetainedLicense.Size = new System.Drawing.Size(281, 118);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(280, 38);
            this.toolStripMenuItem3.Text = "Show Person Details";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(280, 38);
            this.toolStripMenuItem5.Text = "Show License Details";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // cntxPDelete
            // 
            this.cntxPDelete.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.cntxPDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxPDelete.Name = "cntxPDelete";
            this.cntxPDelete.Size = new System.Drawing.Size(280, 38);
            this.cntxPDelete.Text = "Show Person License History";
            this.cntxPDelete.Click += new System.EventHandler(this.cntxPDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(482, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "List Detained Licenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Filter By : ";
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(1114, 676);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 47;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.Detain_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(549, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 167);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::DVLD_Project.Properties.Resources.Detain_64;
            this.btnAddUser.Location = new System.Drawing.Point(1171, 216);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 77);
            this.btnAddUser.TabIndex = 52;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // button1
            // 
            this.button1.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_64;
            this.button1.Location = new System.Drawing.Point(1050, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 77);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmShowDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtSearchDrivers);
            this.Controls.Add(this.cmbSearchDrivers);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecor);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.dvgDetainedLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "frmShowDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Show Detained License";
            this.Load += new System.EventHandler(this.frmShowDetainedLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetainedLicense)).EndInit();
            this.cntxDetainedLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchDrivers;
        private System.Windows.Forms.ComboBox cmbSearchDrivers;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecor;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.DataGridView dvgDetainedLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cntxDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cntxPDelete;
    }
}