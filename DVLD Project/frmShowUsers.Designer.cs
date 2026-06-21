namespace DVLD_Project
{
    partial class frmShowUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUsers));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.lblRecor = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cmbSearchUsers = new System.Windows.Forms.ComboBox();
            this.cmbIsActive = new System.Windows.Forms.ComboBox();
            this.txtSearchUsers = new System.Windows.Forms.TextBox();
            this.dvgUser = new System.Windows.Forms.DataGridView();
            this.cntxUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxPAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxPDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).BeginInit();
            this.cntxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filter By : ";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(1050, 193);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 77);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(524, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 144);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(492, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserFrm.Image")));
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(993, 653);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 15;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(32, 661);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 16;
            this.lblRecor.Text = "#Records : ";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(175, 661);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 29);
            this.lblRecords.TabIndex = 17;
            // 
            // cmbSearchUsers
            // 
            this.cmbSearchUsers.FormattingEnabled = true;
            this.cmbSearchUsers.Location = new System.Drawing.Point(169, 224);
            this.cmbSearchUsers.Name = "cmbSearchUsers";
            this.cmbSearchUsers.Size = new System.Drawing.Size(184, 24);
            this.cmbSearchUsers.TabIndex = 18;
            this.cmbSearchUsers.SelectedIndexChanged += new System.EventHandler(this.cmbSearchUsers_SelectedIndexChanged_1);
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Location = new System.Drawing.Point(379, 224);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(191, 24);
            this.cmbIsActive.TabIndex = 19;
            this.cmbIsActive.Visible = false;
            this.cmbIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbIsActive_SelectedIndexChanged);
            // 
            // txtSearchUsers
            // 
            this.txtSearchUsers.Location = new System.Drawing.Point(379, 224);
            this.txtSearchUsers.Multiline = true;
            this.txtSearchUsers.Name = "txtSearchUsers";
            this.txtSearchUsers.Size = new System.Drawing.Size(191, 24);
            this.txtSearchUsers.TabIndex = 20;
            this.txtSearchUsers.TextChanged += new System.EventHandler(this.txtSearchUsers_TextChanged_2);
            this.txtSearchUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchUsers_KeyPress);
            // 
            // dvgUser
            // 
            this.dvgUser.AllowUserToAddRows = false;
            this.dvgUser.AllowUserToDeleteRows = false;
            this.dvgUser.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUser.ContextMenuStrip = this.cntxUser;
            this.dvgUser.Location = new System.Drawing.Point(37, 276);
            this.dvgUser.Name = "dvgUser";
            this.dvgUser.ReadOnly = true;
            this.dvgUser.RowHeadersWidth = 51;
            this.dvgUser.RowTemplate.Height = 24;
            this.dvgUser.Size = new System.Drawing.Size(1103, 371);
            this.dvgUser.TabIndex = 14;
            this.dvgUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUser_CellContentClick);
            this.dvgUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgUser_MouseDown);
            // 
            // cntxUser
            // 
            this.cntxUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripSeparator5,
            this.cntxPAddUser,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.cntxPDelete});
            this.cntxUser.Name = "cntxPeoples";
            this.cntxUser.Size = new System.Drawing.Size(210, 200);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(209, 38);
            this.toolStripMenuItem3.Text = "Show Details";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(206, 6);
            // 
            // cntxPAddUser
            // 
            this.cntxPAddUser.Image = ((System.Drawing.Image)(resources.GetObject("cntxPAddUser.Image")));
            this.cntxPAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxPAddUser.Name = "cntxPAddUser";
            this.cntxPAddUser.Size = new System.Drawing.Size(209, 38);
            this.cntxPAddUser.Text = "Add New User";
            this.cntxPAddUser.Click += new System.EventHandler(this.cntxPAddUser_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(209, 38);
            this.toolStripMenuItem4.Text = "Edit";
            this.toolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(209, 38);
            this.toolStripMenuItem5.Text = "Delete";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // cntxPDelete
            // 
            this.cntxPDelete.Image = ((System.Drawing.Image)(resources.GetObject("cntxPDelete.Image")));
            this.cntxPDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxPDelete.Name = "cntxPDelete";
            this.cntxPDelete.Size = new System.Drawing.Size(209, 38);
            this.cntxPDelete.Text = "Change Password";
            this.cntxPDelete.Click += new System.EventHandler(this.cntxPDelete_Click_1);
            // 
            // frmShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 711);
            this.Controls.Add(this.txtSearchUsers);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.cmbSearchUsers);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecor);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.dvgUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label3);
            this.Name = "frmShowUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Info";
            this.Load += new System.EventHandler(this.frmUsersInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).EndInit();
            this.cntxUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.Label lblRecor;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ComboBox cmbSearchUsers;
        private System.Windows.Forms.ComboBox cmbIsActive;
        private System.Windows.Forms.TextBox txtSearchUsers;
        private System.Windows.Forms.DataGridView dvgUser;
        private System.Windows.Forms.ContextMenuStrip cntxUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cntxPAddUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cntxPDelete;
    }
}