namespace DVLD_Project
{
    partial class frmShowPeoples
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
            this.dvgPeople = new System.Windows.Forms.DataGridView();
            this.cntxPeoples = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxPShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cntxPAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxPEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxPDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPeopleRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSearchPeoples = new System.Windows.Forms.ComboBox();
            this.txtSearchPeoples = new System.Windows.Forms.TextBox();
            this.lblPeoplesNumber = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnClosePeopleFrm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPeople)).BeginInit();
            this.cntxPeoples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(680, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Peoples";
            // 
            // dvgPeople
            // 
            this.dvgPeople.AllowUserToAddRows = false;
            this.dvgPeople.AllowUserToDeleteRows = false;
            this.dvgPeople.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPeople.ContextMenuStrip = this.cntxPeoples;
            this.dvgPeople.Location = new System.Drawing.Point(12, 318);
            this.dvgPeople.Name = "dvgPeople";
            this.dvgPeople.ReadOnly = true;
            this.dvgPeople.RowHeadersWidth = 51;
            this.dvgPeople.RowTemplate.Height = 24;
            this.dvgPeople.Size = new System.Drawing.Size(1527, 406);
            this.dvgPeople.TabIndex = 2;
            this.dvgPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPeople_CellContentClick);
            this.dvgPeople.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dvgPeople_MouseDown);
            // 
            // cntxPeoples
            // 
            this.cntxPeoples.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxPeoples.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxPShowDetails,
            this.toolStripSeparator1,
            this.cntxPAddPerson,
            this.cntxPEdit,
            this.cntxPDelete});
            this.cntxPeoples.Name = "cntxPeoples";
            this.cntxPeoples.Size = new System.Drawing.Size(212, 194);
            // 
            // cntxPShowDetails
            // 
            this.cntxPShowDetails.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.cntxPShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxPShowDetails.Name = "cntxPShowDetails";
            this.cntxPShowDetails.Size = new System.Drawing.Size(211, 46);
            this.cntxPShowDetails.Text = "Show Details";
            this.cntxPShowDetails.Click += new System.EventHandler(this.cntxPShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // cntxPAddPerson
            // 
            this.cntxPAddPerson.Image = global::DVLD_Project.Properties.Resources.Add_Person_40;
            this.cntxPAddPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxPAddPerson.Name = "cntxPAddPerson";
            this.cntxPAddPerson.Size = new System.Drawing.Size(211, 46);
            this.cntxPAddPerson.Text = "Add New Person";
            this.cntxPAddPerson.Click += new System.EventHandler(this.cntxPAddPerson_Click);
            // 
            // cntxPEdit
            // 
            this.cntxPEdit.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.cntxPEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxPEdit.Name = "cntxPEdit";
            this.cntxPEdit.Size = new System.Drawing.Size(211, 46);
            this.cntxPEdit.Text = "Edit";
            this.cntxPEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cntxPEdit.Click += new System.EventHandler(this.cntxPEdit_Click);
            // 
            // cntxPDelete
            // 
            this.cntxPDelete.Image = global::DVLD_Project.Properties.Resources.Delete_32;
            this.cntxPDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cntxPDelete.Name = "cntxPDelete";
            this.cntxPDelete.Size = new System.Drawing.Size(211, 46);
            this.cntxPDelete.Text = "Delete";
            this.cntxPDelete.Click += new System.EventHandler(this.cntxPDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 741);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "#Records : ";
            // 
            // lblPeopleRecords
            // 
            this.lblPeopleRecords.AutoSize = true;
            this.lblPeopleRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleRecords.Location = new System.Drawing.Point(197, 741);
            this.lblPeopleRecords.Name = "lblPeopleRecords";
            this.lblPeopleRecords.Size = new System.Drawing.Size(0, 29);
            this.lblPeopleRecords.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By : ";
            // 
            // cmbSearchPeoples
            // 
            this.cmbSearchPeoples.FormattingEnabled = true;
            this.cmbSearchPeoples.Items.AddRange(new object[] {
            "Person_Id",
            "National_No",
            "First_Name",
            "Second_Name",
            "Third_Name",
            "Last_Name",
            "Nationality",
            "Gendor",
            "Phone ",
            "Email"});
            this.cmbSearchPeoples.Location = new System.Drawing.Point(182, 264);
            this.cmbSearchPeoples.Name = "cmbSearchPeoples";
            this.cmbSearchPeoples.Size = new System.Drawing.Size(173, 24);
            this.cmbSearchPeoples.TabIndex = 8;
            this.cmbSearchPeoples.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSearchPeoples
            // 
            this.txtSearchPeoples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPeoples.Location = new System.Drawing.Point(381, 259);
            this.txtSearchPeoples.Multiline = true;
            this.txtSearchPeoples.Name = "txtSearchPeoples";
            this.txtSearchPeoples.Size = new System.Drawing.Size(191, 38);
            this.txtSearchPeoples.TabIndex = 9;
            this.txtSearchPeoples.TextChanged += new System.EventHandler(this.txtSearchPeoples_TextChanged);
            this.txtSearchPeoples.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchPeoples_KeyPress);
            // 
            // lblPeoplesNumber
            // 
            this.lblPeoplesNumber.AutoSize = true;
            this.lblPeoplesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeoplesNumber.Location = new System.Drawing.Point(177, 741);
            this.lblPeoplesNumber.Name = "lblPeoplesNumber";
            this.lblPeoplesNumber.Size = new System.Drawing.Size(20, 29);
            this.lblPeoplesNumber.TabIndex = 10;
            this.lblPeoplesNumber.Text = " ";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD_Project.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(1457, 259);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(82, 53);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnClosePeopleFrm
            // 
            this.btnClosePeopleFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePeopleFrm.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClosePeopleFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePeopleFrm.Location = new System.Drawing.Point(1392, 741);
            this.btnClosePeopleFrm.Name = "btnClosePeopleFrm";
            this.btnClosePeopleFrm.Size = new System.Drawing.Size(147, 48);
            this.btnClosePeopleFrm.TabIndex = 5;
            this.btnClosePeopleFrm.Text = "Close";
            this.btnClosePeopleFrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClosePeopleFrm.UseVisualStyleBackColor = true;
            this.btnClosePeopleFrm.Click += new System.EventHandler(this.btnClosePeopleFrm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.People_400;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(702, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmShowPeoples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 814);
            this.Controls.Add(this.lblPeoplesNumber);
            this.Controls.Add(this.txtSearchPeoples);
            this.Controls.Add(this.cmbSearchPeoples);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClosePeopleFrm);
            this.Controls.Add(this.lblPeopleRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmShowPeoples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Peoples";
            this.Load += new System.EventHandler(this.frmShowPeoples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPeople)).EndInit();
            this.cntxPeoples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPeopleRecords;
        private System.Windows.Forms.Button btnClosePeopleFrm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ComboBox cmbSearchPeoples;
        private System.Windows.Forms.TextBox txtSearchPeoples;
        private System.Windows.Forms.ContextMenuStrip cntxPeoples;
        private System.Windows.Forms.ToolStripMenuItem cntxPShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cntxPAddPerson;
        private System.Windows.Forms.ToolStripMenuItem cntxPEdit;
        private System.Windows.Forms.ToolStripMenuItem cntxPDelete;
        private System.Windows.Forms.Label lblPeoplesNumber;
    }
}