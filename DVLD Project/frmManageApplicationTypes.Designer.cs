namespace DVLD_Project
{
    partial class frmManageApplicationTypes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvgAppsTypes = new System.Windows.Forms.DataGridView();
            this.cntxApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.k = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecor = new System.Windows.Forms.Label();
            this.lblTypesNumber = new System.Windows.Forms.Label();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppsTypes)).BeginInit();
            this.cntxApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(243, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Application Types";
            // 
            // dvgAppsTypes
            // 
            this.dvgAppsTypes.AllowUserToAddRows = false;
            this.dvgAppsTypes.AllowUserToDeleteRows = false;
            this.dvgAppsTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgAppsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAppsTypes.ContextMenuStrip = this.cntxApplicationTypes;
            this.dvgAppsTypes.Location = new System.Drawing.Point(12, 211);
            this.dvgAppsTypes.Name = "dvgAppsTypes";
            this.dvgAppsTypes.ReadOnly = true;
            this.dvgAppsTypes.RowHeadersWidth = 51;
            this.dvgAppsTypes.RowTemplate.Height = 24;
            this.dvgAppsTypes.Size = new System.Drawing.Size(792, 371);
            this.dvgAppsTypes.TabIndex = 15;
            this.dvgAppsTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAppsTypes_CellContentClick);
            this.dvgAppsTypes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgAppsTypes_MouseDown);
            // 
            // cntxApplicationTypes
            // 
            this.cntxApplicationTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.k});
            this.cntxApplicationTypes.Name = "cntxPeoples";
            this.cntxApplicationTypes.Size = new System.Drawing.Size(237, 42);
            // 
            // k
            // 
            this.k.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.k.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(236, 38);
            this.k.Text = "Edit Application Type";
            this.k.Click += new System.EventHandler(this.k_Click);
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(12, 594);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 17;
            this.lblRecor.Text = "#Records : ";
            // 
            // lblTypesNumber
            // 
            this.lblTypesNumber.AutoSize = true;
            this.lblTypesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypesNumber.Location = new System.Drawing.Point(147, 594);
            this.lblTypesNumber.Name = "lblTypesNumber";
            this.lblTypesNumber.Size = new System.Drawing.Size(34, 29);
            this.lblTypesNumber.TabIndex = 19;
            this.lblTypesNumber.Text = "0 ";
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(657, 594);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 18;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(330, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 655);
            this.Controls.Add(this.lblTypesNumber);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.lblRecor);
            this.Controls.Add(this.dvgAppsTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppsTypes)).EndInit();
            this.cntxApplicationTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgAppsTypes;
        private System.Windows.Forms.Label lblRecor;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.Label lblTypesNumber;
        private System.Windows.Forms.ContextMenuStrip cntxApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem k;
    }
}