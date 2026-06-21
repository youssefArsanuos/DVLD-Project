namespace DVLD_Project
{
    partial class ctrPersonWithSearchBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtUSearchPerson = new System.Windows.Forms.TextBox();
            this.cmbUSearchPeoples = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrPerson1 = new DVLD_Project.ctrPerson();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchPerson);
            this.groupBox1.Controls.Add(this.btnAddPerson);
            this.groupBox1.Controls.Add(this.txtUSearchPerson);
            this.groupBox1.Controls.Add(this.cmbUSearchPeoples);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 94);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
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
            this.txtUSearchPerson.Location = new System.Drawing.Point(351, 46);
            this.txtUSearchPerson.Name = "txtUSearchPerson";
            this.txtUSearchPerson.Size = new System.Drawing.Size(234, 22);
            this.txtUSearchPerson.TabIndex = 10;
            this.txtUSearchPerson.TextChanged += new System.EventHandler(this.txtUSearchPerson_TextChanged);
            this.txtUSearchPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUSearchPerson_KeyPress);
            // 
            // cmbUSearchPeoples
            // 
            this.cmbUSearchPeoples.FormattingEnabled = true;
            this.cmbUSearchPeoples.Location = new System.Drawing.Point(144, 46);
            this.cmbUSearchPeoples.Name = "cmbUSearchPeoples";
            this.cmbUSearchPeoples.Size = new System.Drawing.Size(201, 24);
            this.cmbUSearchPeoples.TabIndex = 9;
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
            // ctrPerson1
            // 
            this.ctrPerson1.Location = new System.Drawing.Point(4, 103);
            this.ctrPerson1.Mode = 0;
            this.ctrPerson1.Name = "ctrPerson1";
            this.ctrPerson1.PersonId = 0;
            this.ctrPerson1.Size = new System.Drawing.Size(1037, 459);
            this.ctrPerson1.TabIndex = 40;
            this.ctrPerson1.Load += new System.EventHandler(this.ctrPerson1_Load);
            // 
            // ctrPersonWithSearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrPerson1);
            this.Name = "ctrPersonWithSearchBar";
            this.Size = new System.Drawing.Size(1054, 568);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtUSearchPerson;
        private System.Windows.Forms.ComboBox cmbUSearchPeoples;
        private System.Windows.Forms.Label label2;
        private ctrPerson ctrPerson1;
    }
}
