namespace DVLD_Project
{
    partial class frmShowDrivers
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
            this.txtSearchDrivers = new System.Windows.Forms.TextBox();
            this.cmbSearchDrivers = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecor = new System.Windows.Forms.Label();
            this.dvgDrivers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchDrivers
            // 
            this.txtSearchDrivers.Location = new System.Drawing.Point(351, 235);
            this.txtSearchDrivers.Multiline = true;
            this.txtSearchDrivers.Name = "txtSearchDrivers";
            this.txtSearchDrivers.Size = new System.Drawing.Size(191, 24);
            this.txtSearchDrivers.TabIndex = 42;
            this.txtSearchDrivers.TextChanged += new System.EventHandler(this.txtSearchDrivers_TextChanged);
            // 
            // cmbSearchDrivers
            // 
            this.cmbSearchDrivers.FormattingEnabled = true;
            this.cmbSearchDrivers.Location = new System.Drawing.Point(152, 235);
            this.cmbSearchDrivers.Name = "cmbSearchDrivers";
            this.cmbSearchDrivers.Size = new System.Drawing.Size(184, 24);
            this.cmbSearchDrivers.TabIndex = 41;
            this.cmbSearchDrivers.SelectedIndexChanged += new System.EventHandler(this.cmbSearchDrivers_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(158, 672);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 29);
            this.lblRecords.TabIndex = 40;
            this.lblRecords.Click += new System.EventHandler(this.lblRecords_Click);
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(15, 672);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 39;
            this.lblRecor.Text = "#Records : ";
            this.lblRecor.Click += new System.EventHandler(this.lblRecor_Click);
            // 
            // dvgDrivers
            // 
            this.dvgDrivers.AllowUserToAddRows = false;
            this.dvgDrivers.AllowUserToDeleteRows = false;
            this.dvgDrivers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDrivers.Location = new System.Drawing.Point(20, 287);
            this.dvgDrivers.Name = "dvgDrivers";
            this.dvgDrivers.ReadOnly = true;
            this.dvgDrivers.RowHeadersWidth = 51;
            this.dvgDrivers.RowTemplate.Height = 24;
            this.dvgDrivers.Size = new System.Drawing.Size(1077, 371);
            this.dvgDrivers.TabIndex = 37;
            this.dvgDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDrivers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(465, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Manage Drivers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Filter By : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(950, 664);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 38;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.Driver_Main;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(471, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 167);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmShowDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 728);
            this.Controls.Add(this.txtSearchDrivers);
            this.Controls.Add(this.cmbSearchDrivers);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecor);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.dvgDrivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "frmShowDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Drivers";
            this.Load += new System.EventHandler(this.frmShowDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDrivers)).EndInit();
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
        private System.Windows.Forms.DataGridView dvgDrivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}