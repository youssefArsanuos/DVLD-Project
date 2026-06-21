namespace DVLD_Project
{
    partial class frmTestTypes
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
            this.lblTestTypesNumber = new System.Windows.Forms.Label();
            this.lblRecor = new System.Windows.Forms.Label();
            this.dvgTestTypes = new System.Windows.Forms.DataGridView();
            this.cntxTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.k = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseUserFrm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestTypes)).BeginInit();
            this.cntxTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestTypesNumber
            // 
            this.lblTestTypesNumber.AutoSize = true;
            this.lblTestTypesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypesNumber.Location = new System.Drawing.Point(148, 591);
            this.lblTestTypesNumber.Name = "lblTestTypesNumber";
            this.lblTestTypesNumber.Size = new System.Drawing.Size(34, 29);
            this.lblTestTypesNumber.TabIndex = 25;
            this.lblTestTypesNumber.Text = "0 ";
            // 
            // lblRecor
            // 
            this.lblRecor.AutoSize = true;
            this.lblRecor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecor.Location = new System.Drawing.Point(13, 591);
            this.lblRecor.Name = "lblRecor";
            this.lblRecor.Size = new System.Drawing.Size(146, 29);
            this.lblRecor.TabIndex = 23;
            this.lblRecor.Text = "#Records : ";
            // 
            // dvgTestTypes
            // 
            this.dvgTestTypes.AllowUserToAddRows = false;
            this.dvgTestTypes.AllowUserToDeleteRows = false;
            this.dvgTestTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTestTypes.ContextMenuStrip = this.cntxTestTypes;
            this.dvgTestTypes.Location = new System.Drawing.Point(13, 208);
            this.dvgTestTypes.Name = "dvgTestTypes";
            this.dvgTestTypes.ReadOnly = true;
            this.dvgTestTypes.RowHeadersWidth = 51;
            this.dvgTestTypes.RowTemplate.Height = 24;
            this.dvgTestTypes.Size = new System.Drawing.Size(896, 371);
            this.dvgTestTypes.TabIndex = 22;
            this.dvgTestTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTestTypes_CellContentClick);
            this.dvgTestTypes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgAppsTypes_MouseDown);
            // 
            // cntxTestTypes
            // 
            this.cntxTestTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.k});
            this.cntxTestTypes.Name = "cntxPeoples";
            this.cntxTestTypes.Size = new System.Drawing.Size(186, 42);
            // 
            // k
            // 
            this.k.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.k.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(185, 38);
            this.k.Text = "Edit Test Type";
            this.k.Click += new System.EventHandler(this.k_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(339, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Manage Test Types";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCloseUserFrm
            // 
            this.btnCloseUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUserFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCloseUserFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUserFrm.Location = new System.Drawing.Point(762, 591);
            this.btnCloseUserFrm.Name = "btnCloseUserFrm";
            this.btnCloseUserFrm.Size = new System.Drawing.Size(147, 48);
            this.btnCloseUserFrm.TabIndex = 24;
            this.btnCloseUserFrm.Text = "Close";
            this.btnCloseUserFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseUserFrm.UseVisualStyleBackColor = true;
            this.btnCloseUserFrm.Click += new System.EventHandler(this.btnCloseUserFrm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(377, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 649);
            this.Controls.Add(this.lblTestTypesNumber);
            this.Controls.Add(this.btnCloseUserFrm);
            this.Controls.Add(this.lblRecor);
            this.Controls.Add(this.dvgTestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Types";
            this.Load += new System.EventHandler(this.frmTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestTypes)).EndInit();
            this.cntxTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestTypesNumber;
        private System.Windows.Forms.Button btnCloseUserFrm;
        private System.Windows.Forms.Label lblRecor;
        private System.Windows.Forms.DataGridView dvgTestTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cntxTestTypes;
        private System.Windows.Forms.ToolStripMenuItem k;
    }
}